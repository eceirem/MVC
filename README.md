# ASP.NET Core MVC Repository Overview

Welcome to my ASP.NET Core MVC repository! This repository contains materials related to my MVC project, including the controller, views, layout modifications, and upcoming additions.

## Table of Contents

- [Introduction](#introduction)
- [Controller](#controller)
- [View](#view)
- [Layout Modifications](#layout-modifications)
- [Model](#model)
- [Conclusion](#conclusion)

## Introduction

This repository provides a comprehensive example of an ASP.NET Core MVC application. It includes implementations and modifications related to basic MVC components used in this project.

## Controller

The `HelloWorldController` class is a foundational component of this application. It includes:

- **String Method:** A method that returns a simple string. That was my first step to see whats going on in localhost{PORT}/HelloWorld
- **View Method:** A method that returns a view, which is linked to the corresponding view files. After that step i added a view in this project.

## View

The `Views/HelloWorld` directory contains two view files:

- **Index.cshtml:** The main view for the HelloWorld controller.
- **Welcome.cshtml:** An additional view for displaying content.

These views are used to render data and interact with the user interface.

## Layout Modifications

The Layout.cshtml file in the Views/Shared directory has been updated to modify the title and footer. 
Additionally, I've learned about the differences between areas and models in the ASP.NET Core MVC framework.

## Model

Plans to add models to the project will include creating classes that represent data and manage business logic. This will enhance the application's ability to handle and process data effectively.

## Conclusion

This repository serves as a practical example of an ASP.NET Core MVC application with key components and modifications. 
In the development of this project, I utilized the Microsoft tutorial, which you can find [here](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio).

Thank you for exploring the repository!
