using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RapperAPI.Models;

namespace RapperAPI.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
        }

    }
}