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


