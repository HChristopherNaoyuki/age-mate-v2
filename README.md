# README

## Table of Contents
1. [Project Overview](#project-overview)
2. [Technology Stack](#technology-stack)
3. [Project Structure](#project-structure)
4. [Installation and Setup](#installation-and-setup)
5. [Features](#features)
6. [Model Implementation](#model-implementation)
7. [Controller Implementation](#controller-implementation)
8. [View Implementation](#view-implementation)
9. [Styling and Design](#styling-and-design)
10. [Running the Application](#running-the-application)
11. [Disclaimer](#disclaimer)

## Project Overview
Age Mate v2 is an ASP.NET Core MVC web application designed 
to calculate and display the sum of two ages. The application 
features a clean, minimal user interface with Apple-inspired design elements.

## Technology Stack
- ASP.NET Core MVC
- Bootstrap
- HTML5/CSS3
- C#

## Project Structure
```
age-mate-v2/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   ├── AgeDetails.cs
│   └── ErrorViewModel.cs
├── Views/
│   ├── _ViewImports.cshtml
│   ├── _ViewStart.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _Layout.cshtml.css
│       ├── _ValidationScriptsPartial.cshtml
│       └── Error.cshtml
├── wwwroot/
│   ├── css/
│   │   └── site.css
│   ├── js/
│   │   └── site.js
│   ├── lib/
│   └── favicon.ico
├── appsettings.json
└── Program.cs
```

## Installation and Setup
1. Clone the repository: `git clone https://github.com/HChristopherNaoyuki/age-mate-v2.git`
2. Navigate to the project directory
3. Restore dependencies: `dotnet restore`
4. Build the project: `dotnet build`
5. Run the application: `dotnet run`

## Features
- Age calculation functionality
- Clean, minimal user interface
- Responsive design
- Model-View-Controller architecture

## Model Implementation
The `AgeDetails` model contains three properties:
- Age1: First age value
- Age2: Second age value
- TotalAge: Sum of Age1 and Age2

The constructor automatically calculates the total when instances are created.

## Controller Implementation
The `HomeController` creates an instance of `AgeDetails` with sample values (25 and 35) and passes it to the Index view.

## View Implementation
The Index view displays:
- First age value
- Second age value
- Total age calculation

## Styling and Design
The application features a minimal Apple-inspired design with:
- Clean typography using system fonts
- Subtle background colors
- Blurred navigation background effect
- Minimal borders and spacing

## Running the Application

After completing the installation steps, navigate to the URL shown in the console (typically https://localhost:7000 or http://localhost:5000) to view the application.

## Disclaimer

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---
