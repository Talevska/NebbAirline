<h1># NebbAirline</h1>
<h2>Airline Booking System</h2>

<h3>Nebb Coding Project</h3>

<h2>HIGH-LEVEL GOAL</h2>
The high-level goal of the coding project is to implement a web-based application to book airplane tickets
for an airline company. The tool should enable listing, adding, editing, and deleting airplane tickets. The
company has a specific format for the tickets with required and optional data explained below.

<h3>TASK 1: WEB API</h3>
<p>Create a .NET Core based RESTful API that will enable basic CRUD operations on airline tickets. The domain
model consists of one entity: an airline ticket. The entity properties can be extracted from the mockups
defined in TASK 2. The RESTful API should be implemented with the best software engineering practices
and design patterns in mind.</p>

<h3>TASK 2: FRONTEND APPLICATION</h3>
<p>Create a frontend application that will consume the RESTful API defined in TASK 1. The frontend application
should follow the latest software engineering practices and design patterns. The frontend application can
be built with MVC or any other frontend JavaScript/TypeScript framework. For the UI elements, any UI
framework can be used (Bootstrap, Material, etc.), and a ready-made template is acceptable.</p> 

<h4>The application should provide a user interface for the following use cases:</h4>
<ul>
  <li>List all flights</li>
  <li> When a flight is clicked list flight information and all of the passengers for the flight (from the submitted airline tickets)</li>
  <li>Add an airline ticket</li>
  <li>Edit an airline ticket</li>
  <li>Delete airline tickets</li>
</ul>

<h4>Below is the mockup for creating (and editing) a ticket:</h4> 
<p align="center">
  <img src=<img href = "Mockup.png"></img>
 width="350" title="hover text">
</p>
/*![Mockup](Mockup.png)*/

<h4>Please make sure that the submitted assignment:</h4>
<ul>
  <li>Compiles and runs from Visual Studio</li>
  <li>Handles any invalid input appropriately</li>
  <li>Use Passport # for identifying passengers</li>
  <li>Use Flight Code for identifying flights</li>
  <li>When an existing value is inserted in the Passport # textbox prepopulate the empty fields with
the values for the existing passenger</li>
  <li>When an existing value is inserted in the Flight Code textbox prepopulate the empty fields with
the values for the existing flight</li>
</ul>
