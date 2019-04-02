console.log("_________ Challenge one ________")

let students = [
    {name: 'Remy', cohort: 'Jan'},
    {name: 'Genevieve', cohort: 'March'},
    {name: 'Chuck', cohort: 'Jan'},
    {name: 'Osmund', cohort: 'June'},
    {name: 'Nikki', cohort: 'June'},
    {name: 'Boris', cohort: 'June'}
];

for(student in students){
    console.log(`Name: ${students[student].name}, Cohort: ${students[student].cohort}`);
}


console.log("_________ Challenge two ________")

let users = {
    employees: [
        {'first_name':  'Miguel', 'last_name' : 'Jones'},
        {'first_name' : 'Ernie', 'last_name' : 'Bertson'},
        {'first_name' : 'Nora', 'last_name' : 'Lu'},
        {'first_name' : 'Sally', 'last_name' : 'Barkyoumb'}
    ],
    managers: [
       {'first_name' : 'Lillian', 'last_name' : 'Chambers'},
       {'first_name' : 'Gordon', 'last_name' : 'Poe'}
    ]
 };

 for(group in users){
     console.log(group.toUpperCase());
     for(emp in users[group]){
        str = ""
        num = parseInt(emp, 10) + 1; 
        str += num;
        str += " - ";
        str += users[group][emp].last_name.toUpperCase();
        str += ", ";
        str += users[group][emp].first_name.toUpperCase();
        str += " - ";
        count = users[group][emp].last_name.length + users[group][emp].first_name.length
        str += count;
        console.log(str);
    }
}