## Your Name:


# CIDM 3312 Lab 9: EF Core Relationships

You are starting a new movie streaming service. You must ink a contract with two large movie studioes before you can go live. Create a proof of concept app using EF Core that can store information about movies and the movie studios.

Complete the following tasks:

Development tip: Delete the database and then create it fresh each time by placing `db.Database.EnsureDeleted();` right before `db.Database.EnsureCreated();`.
```
db.Database.EnsureDeleted();
db.Database.EnsureCreated();
```

## Task 0: Prep your project
Clone this repository and create a new EF Core app within Visual Studio Code:

```
dotnet new console
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Task 1
Implement the following Entity Relationship Diagram (ERD) in a new EF Core app. 
![Image of ERD](https://i.imgur.com/LdbMBC7.png)
Remember,
  1. Place your entity classes and dbContext class in a `Models/` folder.
  2. Add two `DBSet<>` properties to the DbContext class - one for each entity class.
  3. Add the NAVIGATION PROPERTIES specific to EF Core that are not included on the ERD.
  
## Task 2
Add the studio "20th Century Fox" with the following movies and save changes directly after:
1. Avatar Genre: Action
2. Deadpool Genre: Action
3. Apollo 13 Genre: Drama
4. The Martian Genre: Sci-Fi

## Task 3
Add the studio "Universal Pictures" with no movies and save changes directly after.

## Task 4
Add a new movie "Jurassic Park" (Genre. Action) to the Universal Pictures studio and save changes directly after.

## Task 5
Apollo 13 was actually released by Universal Pictures, not Fox. Write new code that finds Apollo 13 in the database and moves it to Universal Pictures.

## Task 6
Remove the movie Deadpool using `db.Remove()`.

## Task 7
List all studios and their movies. It should look something like this:
```
20th Century Fox - 2 movies
        Avatar - Action
        The Martian - Sci-Fi

Universal Pictures - 2 movies
        Apollo 13 - Drama
        Jurassic Park - Action
 ```
NOTE: Display the number of movies in each studio as shown (2 movies). Recall that lists have a `.Count` property.

## Task 8
List all the movies sorted from Z-A along with their Studio listed next to them. Your output should look like this:
```
The Martian - Sci-Fi - 20th Century Fox
Jurassic Park - Action - Universal Pictures
Avatar - Action - 20th Century Fox
Apollo 13 - Drama - Universal Pictures
```

## Submit your assignment
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Edit `README.md` and put your name at the top.
3. Push your changes to GitHub:
    - Click the source control icon in VS Code
    - Type in a commit message
    - Click the checkbox icon to commit. (Click yes on the message box to stage your commit)
    - Click the 3 dots icon (...) for more actions and click Push.
4. Or you can push your changes to GitHub using the Terminal:
    ```
    git add -A
    git commit -m "Ready for grading"
    git push
    git status
    ```
4. Verify that your changes are on GitHub.
6. Congratulations! Your lab 9 assignment is complete. 
