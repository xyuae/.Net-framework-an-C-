# Use Collection to Group Objects
## Introduction to collections
Another fundamental component of .Net is the collections library. Collectoins allow us to store data that can be grouped together because that is similiar. Collection also allow us to organie and sort data, as well as 
to iterate or go through the dta, such as in a loop. A collection is held in memory and is just a data structure component of .NET, whereas a database is usually held on disk and is a standalone application.
- Dictionaries for key-value pairs

## Asynchronous Programming
Let's start with an analogy. Traditional synchronous, or non-asynchronous, programming is like decising to bild a house. you start with a foundatoin, then bjuild a frame, blumbing, electrical and so on. On the 
other hand, asynchronous programming is like deciding to build a house, but instead of doing it all yourself, you decide to hire a contractor to do the foundation, another on plumbing, and another for electrical. And at the 
same time you are free to do other things, such as progect manage. 
- Async and Await to manage program flow
- Anonymous functioins, callbacks, and action to manage prorgam flow

### Combine Aspects of Fields and Methods with Class Properties
- Properties
- Auto-implemented propertie for more compact code

### Optimize Applications with Multithreading
- creating a new thread

### Set Default values with Null Coalescing and Null Conditional Operators
### Error handlign with try-catch statements
- use exception filters catch(Exception ex) when (ex.name = 'filter')

### Manage Resoruces Safely with using
- using (var resource = new MyResource()) as long as MyResource implements IDisposable interface

## Entity Framework
Entity framework is an object-relational mapping ORM framework that enables developers to work with relational data as domain-specific objects, eliminating the need for most of the data access plumbing code
that developers usually need to write.

### Benefit of Entity Framework
So there is a lot of benefits to using Entity Framework and ORMs in general. The first that I had mentioned was the reduction of code, the less likelihood that you neeed to write a lot of tedious code. And these tools provide
a host of services that allow developers to focus more on the business logic of the application rather than repetitive CRUD operatons, for example, creating, reading, update, deleting, that type of logic. So besides the reduction of code I also listed nine other benefits.

The next is it facilitates implemetnaiong the domain model [pattern. So, one of the most important reasons ORMs even exist is that your model entities can be based more on real business concepts rather than based on your database strucutre. So you can use terms like movie
or person that refelct the real world so it makes a little bit easier to digest when you are working through business logic. ORM tools provide the functionality, through mapping, between the logical business mdoel
and the physical storage that will ultimately be relfected from teh database. 

There is also chagnes to the object models that are made in one palce. So, for example, once you update your object definitions the ORM will automatically use the updated strcutre for retrievals and updates. There are no SQL update, or delete, or insert statement 
strewn throughout different layers of the applicaiton that need modificaiton. I aslo have listed rich query capability. Entity framework and most ORM tools provide an object oriented query language so it allows the developers to focus on 
the object model and not to have to be concerned with the database strcture or SQL semantics.
The ORM tool, itself, will translate the query language into the appropriate syntax for the database. 

Navigation, you can navigate object relationships transparently, for example, related objects are automatically loaded as needed. So let's say you can have a movie object and if you want to acce3ss its genre you can simply access movie.genre and then the ORM will take care of the loading of the data for 
you without any additional effort on your part.

Data loads are completely configurable, allowing you to laod data appropriate for each scenario. For example, in one scenario yo might want to load a list of movies without any of its child and related objects. while in another scenario y specify to laod a movie with all of its child and related objects. While in another 
scenario you can specify to load a movie with all of its children and line items. A good ORM tool will let you be able to configue going back and forth whether or not you want to show the child items or not without having to do any additonal work. 

Another benefit I want to mention is concurrency support.

