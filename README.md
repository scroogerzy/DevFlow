# DevFlow

DevFlow is a personal software development tracker designed to help developers organize coding projects, learning goals, and development tasks using a Kanban-style workflow.

The application allows developers to manage their work by creating **Boards, Columns, and Cards**. A Board represents a software project or learning goal, Columns represent development stages such as Backlog, In Progress, Testing, and Completed, while Cards represent individual development tasks.

DevFlow helps developers visualize progress, prioritize tasks, and maintain a structured workflow while building software projects.

## Purpose

The purpose of DevFlow is to provide developers with a structured way to plan, organize, and track software development work in one place.

The project focuses on making development tasks easier to manage by providing a visual workflow and clear task progression.

## Tech Stack

The planned technical environment for DevFlow includes:

* C#
* ASP.NET Core
* ASP.NET Core Web API
* Entity Framework Core
* SQLite
* HTML/CSS
* JavaScript
* Git and GitHub

## Current Project Status

DevFlow is currently in the planning and documentation stage.

The repository currently contains project planning, Agile/Scrum documentation, backlog information, architecture decisions, and technical documentation. Application implementation will be developed in later stages.

## Planned Features

* User registration and login
* User logout
* Password reset
* Session security
* Board creation and management
* Column creation and management
* Task card creation and management
* Moving cards between workflow stages
* Task priorities and categories
* Search and filtering
* Productivity tracking

## Architecture

DevFlow is planned around a shared backend API.

The browser communicates with the DevFlow API, while the API handles business logic and communicates with the database. A future mobile application can use the same API.

Browser
   |
   v
DevFlow API
   |
   +----> Database
   |
   +----> Future Mobile App


## Setup

The current repository is a planning and documentation repository, so there is no runnable application to install yet.

## To obtain the project:

git clone https://github.com/scroogerzy/DevFlow.git
cd DevFlow


## Review the planning documentation under:

docs/Planning/


When application implementation is added, this section will be updated with the required .NET SDK version, dependencies, database setup, configuration, and commands for running the application.

## Usage

At the current stage, DevFlow is used as a project planning and documentation workspace.

Users can review:

* `docs/Planning/product-backlog.md` for planned product work.
* `docs/Planning/sprint-1-backlog.md` for Sprint 1 work.
* `docs/Planning/standup-log.md` for progress updates.
* `docs/Planning/architecture-sketch.md` for the planned system architecture.
* `NOTES-Scroogerzy.md` for assignment decisions and reflections.

Once implementation begins, this section will explain how to run DevFlow and use its boards, columns, and task cards.

## Repository Structure

DevFlow/
├── README.md
├── NOTES-Scroogerzy.md
└── docs/
    ├── Planning/
    │   ├── agile-redesign.md
    │   ├── architecture-sketch.md
    │   ├── epics.md
    │   ├── product-backlog.md
    │   ├── sprint-1-backlog.md
    │   ├── sprint-1-retro.md
    │   ├── sprint-1-review.md
    │   └── standup-log.md
    └── QuickNotes/
        ├── SignupService.cs
        ├── README.md
        ├── API.md
        └── ADR.md


## Contribution Guide

For contributions:

1. Create a feature or documentation branch from `main`.
2. Use a clear branch name that describes the work.
3. Make focused changes.
4. Use clear commit messages.
5. Push the branch to GitHub.
6. Open a Pull Request.
7. Explain what changed, why it changed, and how it can be verified.
8. Address reviewer feedback before merging.
9. Merge only after the changes have been reviewed and approved.

## Current Limitations

DevFlow does not currently contain the implemented application or backend API.

The current repository therefore cannot yet be used as a running software application. The documentation describes the planned architecture, features, backlog, and development workflow.

## Roadmap

### Sprint 1

* Authentication foundation
* User registration
* User login
* User logout
* Password reset
* Session security

### Sprint 2

* Boards
* Columns
* Task cards
* Workflow movement

### Sprint 3

* Task management
* Collaboration
* Productivity features

### Sprint 4

* UX improvements
* Testing
* Refinement

## Links

* GitHub Repository:
https://github.com/scroogerzy/DevFlow

* Project Doc:
https://docs.google.com/document/d/1TJJ4lRc0D_B9lXwxO-jxNV6re5kFvvu9ymjRxSiHjdo/edit?usp=sharing

* Task Tracker:
https://docs.google.com/spreadsheets/d/1V0mtKVHs_Xjtclv6CSupga7sMn1uqoxpwgLopEf0PaU/edit?usp=sharing

* Kickoff Deck:
https://docs.google.com/presentation/d/1jJaGpgXH8biicKOWh03hMrReiZAKwPD6uFw36Zz7_j8/edit?usp=sharing 

## License

This project is currently an educational trainee-program project. A formal open-source license will be added if the project is later released publicly.
