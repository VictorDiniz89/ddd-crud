# CRUD-Dev

Basic CRUD Frontend and Backend, developed as an interview task for Hahn Softwareentwicklung.

## Startup

**_In order to run the example, please type ```docker compose up --build``` in the root directory of the repository (/ddd-crud). Please then navigate to Angular application (http://localhost:4200) to access the Angular Front-end application._**

To recreate the image with the testing values in the database, please use ```docker compose up --force-recreate```.


## Task

1. Develop a WebApi based on a DDD Pattern in .Net6
2. Develop a Angular CRUD Application to maintain the data with validation in front and backend ( use FluentValidation Syntax in Both)
3. The Angular Application also should have a overview with an grid
4. The Application should be startable with a docker-compose and checkable
5. The Repository should have a git history.
6. Record a video declaring your applicantion(in English)

In order to make the project more interest, I decided to make it about a Person(User.cs) where you can see whom a Person is (id, title, fistName, lastName, email, role) all those field can't be empity or the FluentValidation(UserValidator.cs) will complain.

## Program and value objects

- In the (Program.cs): there are some details about what kind of Person and how its gonna be their structure in the Front-end(id, title, fistName, lastName, email, role)
- The (UserController.cs) pick it the value of (User.cs) up, which repesents a Person and report contained inside a (UserRepository.cs) object.

# Back-end

For the Web API infrastructure I used .NET 6, implementing the Domain-driven design pattern using "clean" architecture.
The API is divided into 3 different layers:
- Application layer (WebAPI folder)
- Domain layer
- Infrastructure layer

Relevant details:
- Used **LiteDB** as the database for this project due to its ease of use and very low overhead, which I implemented utilizing the **repository pattern**.
- Implemented the IUserService, which controls the repositories and the validation of the (UserRepository.cs) Database.
- Used FluentValidation for validation, located inside the infrastructure layer.

# Front-end

The frontend I have much more experience with browser-based frameworks like Angular and React.
It consists of:
- A main table that lists all (UserRepository.cs) and their properties.
- The ability to create, update, and delete (UserService.cs) and their respective (User.cs).



