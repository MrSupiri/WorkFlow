## 1.0.2 (2022-01-04)

#### Bug Fixes

* Fixed a issue with update project (f544e9d0)

#### Documentation

* Update the changelog (7af52cec)

#### Build

* Added a loader for cloud run bootup (59c3dec1)


## 1.0.1 (2022-01-04)

#### Bug Fixes

* Added a missing relationship fetch (137be2db)

#### Documentation

* Updated demo username (ad56d65c)
* Update the changelog (ee7e87db)

#### Build

* Updated docker build to include a nginx reverse proxy (455d20da)


## 1.0.0 (2022-01-02)

#### Feature

* Added option to users to leave company (3fe7a473)
* Setup Role based UI rendering (7a69edc4)

#### Bug Fixes

* Fixed tickets overview page (b06c4ebb)
* Logging out issue fixed (97af2b73)

#### Documentation

* Updated the docker command (7e83dc56)
* Added a README.md (a0aa3ee4)
* Added doc comments to classes and methods (a01b2220)
* Update the changelog (d3b94de0)

#### Code Refactoring

* Code CleanUp via Rider (52916507)

#### Styles

* Updated implicit variables to explicit types (035a943b)

#### Build

* Update docker image to run independently (c2d37a78)

#### CI

* Promoted the build to stable v1.0 (97e3dfb7)


## 0.4.0 (2022-01-01)

#### Feature

* Created Page for User Report (d6646867)
* Added data forecasting (661116cf)

#### Bug Fixes

* Fixed few UI related Issues (8431f636)

#### Documentation

* Update the changelog (1a308487)


## 0.3.0 (2021-12-31)

#### Feature

* Add and Remove users from projects (b820b38f)
* Invite Users to project (06ad5b1f)
* Added exception handling with toasts (72e5c02b)

#### Bug Fixes

* Added Entity Framework based validation (1fe26c72)
* Added missing attributes to register page (9901c473)

#### Documentation

* Update the changelog (7e2dca4e)

#### Code Refactoring

* Standardize the Models and Services (32e77222)

#### Chores

* Updated packages to .NET 6.0.1 (32934f56)


## 0.2.0 (2021-12-28)

#### Feature

* Created a CSS Loader Animation (81df90af)

#### Bug Fixes

* Setup login redirects (13aa9e22)
* Made NavBar icon dynamic (dde1ba95)
* Handled for users with 0 companies (e11539f2)

#### Documentation

* Update the changelog (3530c2ac)


## 0.1.1 (2021-12-27)

#### Bug Fixes

* Fixed few issues with the CI (ac055ded)

#### Documentation

* Fixed a typo in CHANGELOG.md (29c0ac3c)
* update the changelog (a054a150)

#### CI

* Enabled prepend on semantic-release (4ea7cb37)


## 0.1.0 (2021-12-27)

#### Feature

* Linked user CRUD UIs with API (7fea42c3)
* Linked ticket CRUD UIs with API (ac2fe17b)
* Linked project CRUD UIs with API (54c8bee9)
* Linked company CRUD UIs with API (ca94a01e)
* Created CRUD backend for Project (07a90b9d)
* Created CRUD backend for Company (9c661957)
* Linked ticket UIs with CRUD backend (40a26f08)
* Created CRUD backend for Ticket (7cd179fe)
* Integrated entity framework (259af5da)
* Created the forecasting view (66db4bbd)
* Created CRUD UIs for Ticket (9f8220fb)
* Created RUD UIs for User (743e8cb9)
* Created CRUD UIs for Company (116bb163)
* Created CRUD UIs for Project (c8bde125)
* Added Breadcrumb Navigation (edf35b5e)

#### Bug Fixes

* Enforced unique constraints on URIs (c73969ba)
* Added few missing routes to project and company (e3e0eb3d)
* Fixed breadcrumbs not updating with path changes (70343791)

#### Chores

* Created the CI/CD (4009bccf)

#### Code Refactoring

* Changed to object types (ea50ceda)
* Moved navigation logic to NavService (d07a16d8)
* Moved the project to blazor webassembly (ac159821)
* Updated the folder structure (d48dc32f)

