## Assignment 2.1

# Question 1 — Scrum or Kanban, for two different contexts

## Daily App — Kanban

For my Daily App, DevFlow, I would use Kanban because it is a solo project where I will work in short sessions and the scope may change as I learn new technologies or identify better features.

Kanban fits this project because I can continuously prioritize tasks, move cards through different development stages, and adapt without waiting for a fixed sprint cycle.

Scrum would be less suitable because it requires structured sprints, sprint planning, daily stand-ups, and fixed sprint goals. Since I am working alone and the project requirements will evolve, Kanban provides more flexibility.

## TrackFlow — Scrum

For TrackFlow, I would use Scrum because it is a shared class project involving multiple developers working together toward a common goal.

Scrum provides structure through sprint planning, sprint reviews, and retrospectives. It helps the team coordinate work, divide responsibilities, and regularly inspect progress.

My choice differs because TrackFlow requires collaboration and communication between team members, while DevFlow is an individual project where flexibility is more important.

---

# Question 2 — A real trade-off

One Agile Manifesto value that will create a trade-off while planning DevFlow is:

"Responding to change over following a plan."

While planning DevFlow, I will need to decide whether to strictly follow my original feature plan or change direction when I discover better solutions or user needs.

I will lean toward responding to change because Agile encourages adapting based on learning and feedback. For example, if I discover that a feature such as task filtering is more valuable than notifications, I should adjust the backlog instead of blindly following the original plan.

---

# Question 3 — Critique and redesign

## Problems with the Waterfall-style plan

### 1. Complete requirements before development

The plan requires all requirements to be finalized before building begins. This violates the Agile Manifesto value:

"Customer collaboration over contract negotiation."

It also violates Principle 2:

"Welcome changing requirements, even late in development."

In real projects, users often discover new needs after seeing working software.

---

### 2. No feedback until the entire application is built

The plan only allows demos after development is complete.

This violates Principle 4:

"Business people and developers must work together frequently throughout the project."

Without early feedback, the team may spend weeks building features that do not solve the actual problem.

---

### 3. Testing happens only at the end

The plan delays QA testing until all features are complete.

This violates Principle 8:

"Agile processes promote sustainable development."

Testing continuously during development reduces risks and makes fixing problems easier.

---

# Agile redesign for DevFlow

## Iteration 1 — Core Task Management

Goal:
Create the minimum usable version of DevFlow.

Features:
- Create a development board
- Create columns (Backlog, In Progress, Completed)
- Create, edit and move task cards
- Basic responsive interface

Feedback:
Users test whether the workflow makes sense and provide improvements.

---

## Iteration 2 — Improve Productivity

Goal:
Improve the experience based on feedback.

Features:
- Add task priorities
- Add categories/tags
- Add search and filtering
- Improve user interface

Feedback:
Review whether developers can manage their projects more efficiently and adjust the backlog for future iterations.

## Assignment 2.2

# Question 1 — Roles, solo and shared

## TrackFlow

For TrackFlow, the Product Owner would likely be the instructor because they define the project vision, priorities, and requirements.

The Scrum Master role could be handled by a trainee who helps coordinate meetings, removes blockers, and ensures the team follows Scrum practices.

The Dev Team role would be shared by all trainees because they are responsible for designing, developing, testing, and delivering features.

## Daily App — DevFlow

For DevFlow, I will act as the Product Owner, Scrum Master, and Developer because I am building the application independently.

The role I expect to neglect first is the Scrum Master role because when focusing on development, I may ignore planning, reflection, and maintaining Agile habits.

A habit that would prevent this is scheduling regular weekly reviews where I update my backlog, review progress, and identify blockers before starting new work.

---

# Question 2 — Definition of Ready and Definition of Done

## Definition of Ready — DevFlow Authentication Epic

A backlog item is ready when:

- The user story is clearly written and understandable.
- The purpose of the feature is defined.
- Acceptance criteria are identified.
- Dependencies are known.
- Required technical approach is understood.
- The task is small enough to complete within a sprint.

## Definition of Done — DevFlow Authentication Epic

A backlog item is done when:

- The feature has been implemented.
- The code has been tested.
- The feature works according to acceptance criteria.
- Errors and edge cases have been handled.
- Documentation has been updated if necessary.
- The changes have been committed to Git.

---

# Question 3 — The artifact most at risk

The Scrum artifact most likely to be skipped in a solo project is the Sprint Backlog.

When working alone, it is easy to immediately start coding without selecting specific sprint goals and planned tasks.

The cost of skipping it is losing focus because there is no clear short-term objective. This can lead to unfinished features, changing priorities, and difficulty measuring progress.

## Assignment 2.3

# Question 1 — Choosing a view

The primary view for DevFlow will be the **Board view** because DevFlow uses a Kanban-style workflow. It makes it easy to see tasks moving through stages such as Backlog, In Progress, Testing, and Completed.

The **List view** will help when reviewing the full backlog and checking task details. The **Timeline view** will help with planning dates, dependencies, and longer-term development work.

# Question 2 — Custom fields, deliberately

## Priority

Used to filter tasks by priority so that high-priority work can be identified and completed first.

## Type

Used to distinguish between Features, Bugs, Improvements, and Documentation tasks.

## Story Points

Used to estimate effort and support Sprint Planning by helping decide how much work can reasonably be included in a sprint.

# Question 3 — Tag or field?

A **tag** that DevFlow could use is `needs-design`. It is a flexible label that can be applied to tasks across projects.

A **custom field** should be **Priority** because it needs consistent values and filtering within the DevFlow project.

If Priority were used as a tag, different labels such as `High`, `high`, or `urgent` could make filtering inconsistent. If `needs-design` were a custom field, it would add unnecessary structure to a flexible label.

# NOTES.md Updates

## What the backlog exercise revealed

The backlog exercise revealed that the initial backlog contains useful functionality, but some items need further refinement before development. Breaking broad requirements into smaller tasks makes them easier to understand, estimate, and complete within a sprint.

## Where Sprint 1 Backlog and reality disagreed

The Sprint 1 backlog focused on the Authentication epic with registration, login, and logout. In a real development situation, implementation details, validation requirements, testing, and technical dependencies could make these items larger than initially expected. This shows why the sprint backlog should be reviewed and adjusted as new information is discovered.

## Field vs tag decision

The field versus tag decision could easily be confused when setting up the project in Asana. Priority should be a custom field because it requires consistent values and filtering. A flexible label such as `needs-design` is better suited to a tag.

## Assignment 2.4

# Question 1 — Rewrite Sprint 1 as real user stories

### 1. User registration

As a developer, I want to create a DevFlow account so that I can securely manage my own development projects and tasks.

### 2. User login

As a registered developer, I want to log in to my DevFlow account so that I can access my projects and tasks.

### 3. User logout

As a logged-in developer, I want to log out of DevFlow so that my account remains protected when I finish using the application.

### 4. Password reset

As a DevFlow user, I want to reset my password if I forget it so that I can regain access to my account.

### 5. Session security

As a DevFlow user, I want my login session to remain secure so that other people cannot access my account without permission.

# Question 2 — Acceptance criteria

### User registration

* The user can enter the required registration details.
* The system validates required fields.
* The system prevents registration with an already registered email address.
* A valid registration creates a new user account.

### User login

* A registered user can enter their email and password.
* Correct credentials allow the user to access their account.
* Incorrect credentials display an appropriate error message.
* The user's authenticated session is maintained after successful login.

### User logout

* A logged-in user can select the logout option.
* The current session is ended after logout.
* The user is redirected to the login or appropriate public page.
* Protected pages cannot be accessed through the ended session.

### Password reset

* The user can request a password reset using their registered email address.
* The system confirms that the reset request was received.
* The user can create a new password through the reset process.
* The new password can be used to log in.

### Session security

* An authenticated user receives a valid session after login.
* Protected pages require an authenticated session.
* Logging out invalidates the active session.
* An unauthenticated user cannot access protected account pages.

# Question 3 — INVEST check

I evaluated the **User registration** story.

* **Independent:** Yes, registration can be developed before most other authentication features.
* **Negotiable:** Yes, the exact registration interface and validation details can be refined.
* **Valuable:** Yes, users need an account before they can manage their DevFlow data.
* **Estimable:** Yes, the work can be estimated based on the required form, validation, account creation, and testing.
* **Small:** Yes, the story can reasonably fit within one sprint.
* **Testable:** Yes, successful registration, validation, duplicate accounts, and errors can be tested.

The story passes all INVEST criteria, so no scope change is required.

# Question 4 — Story points

Using the reference-story approach, the Sprint 1 estimates are:

| Story             | Story Points |
| ----------------- | ------------ |
| User registration |            3 |
| User login        |            3 |
| User logout       |            2 |
| Password reset    |            5 |
| Session security  |            5 |

Password reset and session security received higher estimates because they involve more validation, security considerations, and testing than the original rough backlog phrases suggested.

# NOTES.md Updates

## 1. What changed between backlog phrase and real story

The "User login" backlog phrase initially looked like a simple login feature. Writing it as a full user story made the purpose clearer: the goal is not only to enter credentials, but to allow a registered developer to securely access their projects and tasks.

## 2. The retro, from the inside

The TrackFlow retrospective will be used to identify a practical improvement that can be applied to my own sprint retrospective once the class mock sprint has been completed.

## 3. Estimating with real stories vs. rough backlog items

The estimates feel more confident when using complete user stories because the user, purpose, scope, and acceptance criteria are clearer. Rough backlog phrases hide implementation and testing work, which can make the original estimate less reliable.

# Assignment 3.1

## Question 1 — Suggesting mode vs. comments vs. direct edits

Direct edits: I would use direct edits when I have permission to make a change that is already agreed upon. For example, I would directly update the DevFlow project timeline when the team has agreed on new dates.

Suggesting mode: I would use suggesting mode when I want to propose a change to someone else's work without changing the original content permanently. For example, I could suggest changes to the DevFlow project scope for the document owner to accept or reject.

Comments: I would use comments when I need clarification, feedback, or discussion without changing the document. For example, I could comment on the DevFlow project requirements and ask whether a particular feature should be included in the first sprint.

## Question 2 — Permissions, deliberately

Editor: Teammates working directly on the Daily App project will receive Editor access because they need to create, update, and organise project documents and files.

Commenter: The instructor or mentor will receive Commenter access because they need to review the work and provide feedback without changing the project structure or content directly.

Viewer: Other cohorts or people who only need to see the project information will receive Viewer access because they do not need to modify or comment on the project files.

Permissions should be assigned according to the work each person needs to perform rather than giving everyone Editor access.

## Question 3 — Sync or async?

Goal-setting and project documentation should mainly be handled asynchronously in Google Docs because team members can review and contribute without requiring a meeting.

Task assignment should be managed asynchronously using Google Sheets and the project tracker because tasks, owners, statuses, and due dates can be recorded clearly.

Status updates should normally be asynchronous because team members can update the tracker without interrupting development.

Blocking questions should be handled in a live Google Meet when the issue requires discussion, clarification, or a quick decision from multiple people.

A live kickoff meeting should therefore focus on important decisions and blockers, while routine information should remain in Docs, Sheets, and Calendar.

## NOTES.md Updates

### 1. What the “TidyUp” practice revealed

The TidyUp practice showed me the importance of keeping project documents, task tracking, presentations, and meeting information connected. It also helped me understand how permissions, comments, suggestions, and version history support collaboration. I used the same structure for my real DevFlow kickoff.

### 2. The permission I almost got wrong

The main permission risk was giving everyone Editor access by default. I learned that access should depend on what each person actually needs to do. Editors should be able to modify project work, Commenters should provide feedback, and Viewers should only need to see information.

### 3. Sync vs. async, in practice

The kickoff confirmed that routine information such as goals, tasks, progress, and documentation can be handled asynchronously using Docs, Sheets, and Calendar. A live Meet is more useful for discussing blockers, making decisions, and clarifying issues that would take longer to resolve through messages.

## Real DevFlow Workspace Links

DevFlow Drive Folder:
https://drive.google.com/drive/folders/1J8I6zfMzkwQ8EYnUC9HtuUqjcwoHKMt-?usp=sharing

DevFlow Project Doc:
https://docs.google.com/document/d/1TJJ4lRc0D_B9lXwxO-jxNV6re5kFvvu9ymjRxSiHjdo/edit?usp=sharing

DevFlow Task Tracker:
https://docs.google.com/spreadsheets/d/1V0mtKVHs_Xjtclv6CSupga7sMn1uqoxpwgLopEf0PaU/edit?usp=sharing

DevFlow Kickoff Deck:
https://docs.google.com/presentation/d/1jJaGpgXH8biicKOWh03hMrReiZAKwPD6uFw36Zz7_j8/edit?usp=sharing

DevFlow Calendar Event:
https://calendar.app.google/snaD5bkLhJKXSKDa9

## Assignment 3.2

## Question 1 — Beyond the core four

The additional README section DevFlow needs is a **Tech Stack** section. It should identify the main technologies, frameworks, tools, and supporting technologies used by the project.

This is important because a developer cloning the repository needs to understand the technical environment before attempting to set up or run the project. Without this information, they may not know which runtime, framework, database, or development tools are required, which can make setup slower and cause avoidable compatibility problems.

## Question 2 — Comment audit

The current DevFlow capstone repository is primarily a planning and documentation repository and does not currently contain implementation source code with inline code comments. Therefore, I could not honestly identify an existing code comment that restates code or provide a real source-code line without inventing evidence.

However, the architecture documentation contains a non-obvious design decision that benefits from an explanation of why it was chosen: the browser and future mobile application communicate through the same backend API. This is more than a routine implementation detail because it affects the overall architecture and future extensibility of DevFlow.

## Question 3 — What makes a decision ADR-worthy?

A real technical decision in DevFlow is using a shared backend API as the communication layer between the browser, future mobile application, and database.

This decision is ADR-worthy because it affects the overall system architecture rather than a routine implementation detail. It determines how different clients communicate with the system and allows a future mobile application to use the same backend services. Changing this architectural approach later could require significant restructuring, so documenting the decision and its consequences will help future developers understand why it was chosen.

### Assignment 3.2 — Reflection

#### 1. What the sample revealed

The QuickNotes sample showed me that technical documentation should explain the important reasons behind implementation choices instead of documenting every obvious line of code. README files should help a new developer set up and use a project, API documentation should clearly describe how a service is called, and ADRs should record important technical decisions and their consequences.

#### 2. Comment I was wrong about

I initially expected the DevFlow repository to contain implementation comments that could be audited. After checking the repository, I found that the current capstone is primarily a planning and documentation repository and does not yet contain implementation source code. Therefore, I could not honestly remove or rewrite a real code comment without inventing evidence.

#### 3. Decision vs implementation detail

A technical decision should be documented when it has a meaningful impact on the architecture, future development, maintainability, or system behaviour. Routine implementation details do not need an ADR. For DevFlow, using a shared backend API is ADR-worthy because it affects how the browser, future mobile application, and database communicate.

## Assignment 3.2 — Deliverables

* README: `README.md`
* ADR: `docs/decisions/001-shared-backend-api.md`
* Technical documentation: `docs/API/authentication-module.md`
* QuickNotes practice: `QuickNotes/`
