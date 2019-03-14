using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RapperAPI.Models;

namespace RapperAPI.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;
        private List<Group> allGroups;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
            allGroups = JsonToFile<Group>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        [HttpGet("groups")]
        public List<Group> AllGroups()
        {
            return allGroups.ToList();
        }

        [HttpGet("artists")]
        public List<Artist> AllArtists()
        {
            return allArtists.ToList();
        }

        [HttpGet("name/{name}")]
        public List<Artist> Name(string name)
        {
            return allArtists.Where(artist => artist.ArtistName == name).Join(allGroups, artist => artist.GroupId, group => group.Id, (artist, group) => {artist.Group = group; return artist;}).ToList();
        }

        [HttpGet("groupid/{id}")]
        public List<Artist> GroupId(int id)
        {
            return allArtists.Where(artist => artist.GroupId == id).Join(allGroups, artist => artist.GroupId, group => group.Id, (artist, group) => {artist.Group = group; return artist;}).ToList();
        }

        [HttpGet("ListArtists/{boolean}")]
        public List<Group> ListArtists(bool boolean)
        {
            if(boolean == true)
            {
                return allGroups.Join(allArtists, group => group.Id, artist => artist.GroupId, (group, artist) => {group.Members.Add(artist); return group;}).Distinct().ToList();
            }
            else
            {
                return allGroups.ToList();
            }
        }
    }
}