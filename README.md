# Table of contents
* [General description](#general-description)
* [Scope of functionalities](#scope-of-functionalities)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Inspiration](#inspiration)
* [Things To Do](#things-to-do)

# General description
Small university project written in C# with usage of WinForms and mongocsharpdriver libraries. 
Main idea of this project was to avoid writing Mongo queries by "end-user" to communicate with database and wrap them inside C# back-end logic.


In this case database contains information about movies, comments and users which for example could be used on website as a easily editable data repository.

#### Purposes of developing this application were:
* Getting to know the connection between C# and MongoDB
* Better understanding of the MongoDB syntax
* More efficient use of LINQ syntax and WinForms controls


# Scope of functionalities

The project include usage of the best known MongoDB queries by me listed below:

* $lookup / .Lookup()

  Used to "grab" another collection for creating nested grid results. For example when we display all movies from database we also get nested comments with them.

* $project / .Project()

  Simple option which included in query can disable unnecessary fields in result.

* insertOne() / .InsertOne()

  Method that adds a document to specified collection.
  
* insertMany() / .InsertMany()

  Method that adds a list of documents to specified collection.
  
* $in / Filter.AnyIn()

  Very useful method in case of my project. When added as a option to query it allows to find records clicked by user so the application knows which documents should be deleted ( this is only an example ).
  Mentioned method also helps in function which finds orphans to remove them.
  
* $eq / Filter.Eq()

  Filter option that helps us finding fields with specified value in database.
  
* $inc

  Simple incrementation of numeric field.
  
* findOneAndUpdate() / .FindOneAndUpdate()

  It allows to update specified fields in document found by filters.
  
* deleteMany() / .DeleteMany()

  Removing many documents provided in list.
  
Application provides possibility to add, edit, delete and find by phrase.

# Screenshots

![Scr1](https://i.ibb.co/pKXz2L8/scr1.png)
![Scr2](https://i.ibb.co/4Tm5rJV/scr2.png)
![Scr3](https://i.ibb.co/0JwMv9L/scr3.png)


# Technologies

### Languages:
* C#

### Environments:
* RoboMongo 1.3.1
* Visual Studio 16.3.4

### Databases:
* MongoDB

### External libraries used:
* mongocsharpdriver 2.9.3 by vincentkam, dmitry_lukyanov, rstam, craiggwilson

# Inspiration

This idea came out from PhpMyAdmin which provides user-friendly UI that allow to edit the database with ease.


# Things To Do:

* Better organisation of code
* Correct regexes
* Exception protections
* Better UI



