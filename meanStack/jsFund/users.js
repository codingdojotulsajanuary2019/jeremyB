function userLanguages(param){
    var str = ""
    
    for (user in param){
      var count = 0;
      str += param[user].fname;
        str += " ";
        str += param[user].lname;
        str += " knows ";
        for (lang in param[user].languages){
          if(lang == param[user].languages.length-1){
            str += "and ";
            str += param[user].languages[lang];
            str += ".";
          }
          else{
            str += param[user].languages[lang];
            str += ", ";
          }
        }
        console.log(str);
        str = "";
        str += param[user].fname;
        str += " is also interested in ";
        for (int in param[user].interests){
          console.log(int);
            for (thing in param[user].interests[int]){
              var idx = Object.keys(param[user].interests).length-1;
              console.log(thing);
              if(idx == count){
                if(thing == param[user].interests[int].length - 1)
                {
                  str += "and ";
                  str += param[user].interests[int][thing];
                  str += ".";
                }
              }
              else{
                str += param[user].interests[int][thing];
                str += ", ";
              }
            }
            count++;
        }
        console.log(str);
        str = "";
    }

}

users = [
    {
      fname: "Kermit",
      lname: "the Frog",
      languages: ["Python", "JavaScript", "C#", "HTML", "CSS", "SQL"],
      interests: {
        music: ["guitar", "flute"],
        dance: ["tap", "salsa"],
        television: ["Black Mirror", "Stranger Things"]
      }
    },
    {
      fname: "Winnie",
      lname: "the Pooh",
      languages: ["Python", "Swift", "Java"],
      interests: {
        food: ["honey", "honeycomb"],
        flowers: ["honeysuckle"],
        mysteries: ["Heffalumps"]
      }
    },
    {
      fname: "Arthur",
      lname: "Dent",
      languages: ["JavaScript", "HTML", "Go"],
      interests: {
        space: ["stars", "planets", "improbability"],
        home: ["tea", "yellow bulldozers"]
      }
    }
  ]

  userLanguages(users);