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
