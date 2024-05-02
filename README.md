# BloggingPlatform (in progress)

BloggingPlatform is an ASP.NET Core 8 MVC Web Application designed to provide a solution for efficient blog management. It includes features for user authentication, post creation, commenting, and category organization.

## Features

- **Tech Stack**: 
  - .NET Core 8
  - Entity Framework
  - SQL Server
  - ASP.NET Core Identity
  - Bootstrap

- **Database Tables**:
  - Posts
  - Comments
  - Categories
  - Users

- **Authentication/Authorization**:
  - ASP.NET Core Identity

## Project setup

1. Update the database connection string in `appsettings.json`:
```
"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BloggingPlatform;Trusted_Connection=True;TrustServerCertificate=true;"
```

2. Run this command in `Packet Manager Console` to create the necessary database schema:
```
update-database
```

## Role Access Levels

- **Admin**: 
  - Full access to all features and components.
- **Author**
  - Can create, update, and delete their own posts and comments.
- **Reader**: 
  - Can view posts and comments but cannot create or modify content.

## TODO

- [X] Develop functionality for creating, editing, and deleting categories.
- [X] Create database context.
- [X] Implement repository pattern.
- [ ] Implement N-Tier architecture.
- [ ] Develop functionality for creating, editing, and deleting blog posts.
- [ ] Develop functionality for creating, editing, and deleting comments.
- [ ] Add support for tagging blog posts with categories.
- [ ] Implement search functionality for discovering blog posts.
- [ ] Implement user authentication and authorization.
- [ ] Create Homepage layout.
- [ ] Implement Responsive Web Design.
