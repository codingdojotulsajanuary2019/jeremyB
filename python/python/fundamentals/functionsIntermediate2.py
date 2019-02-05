# Update Values in Dictionaries and Lists
x = [ [5,2,3], [10,8,9] ] 
students = [
     {'first_name':  'Michael', 'last_name' : 'Jordan'},
     {'first_name' : 'John', 'last_name' : 'Rosales'}
]
sports_directory = {
    'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
    'soccer' : ['Messi', 'Ronaldo', 'Rooney']
}
z = [ {'x': 10, 'y': 30} ]
x[1][0]=15
students[0]["last_name"] = 'Bryant'
sports_directory["soccer"][0] = 'Andres'
z[0]["y"] = 30

students = [
         {'first_name':  'Michael', 'last_name' : 'Jordan'},
         {'first_name' : 'John', 'last_name' : 'Rosales'},
         {'first_name' : 'Mark', 'last_name' : 'Guillen'},
         {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]

# Iterate Through a List of Dictionaries
def iterateDictionary(x):
    for dictionary in students:
        for i,j in dictionary.items():
            print(i, end=" - ")
            print(j, end=", ")
        print("")
iterateDictionary(students) 

# Get Values From a List of Dictionaries
def iterateDictionary2(key_name, some_list):
    for individuals in some_list:
        for i,j in individuals.items():
            if(i == key_name):
                print(individuals[i])
# iterateDictionary2('last_name',students)


dojo = {
   'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
   'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
}

# Iterate Through a Dictionary with List Values
def printInfo(some_dict):
    for i,j in some_dict.items():
        print(i.upper(), " - ", len(j))
        for k in j:
            print(k)
        print()


printInfo(dojo)