---
title: Create Flight View
---
# Introduction

This document will walk you through the implementation of the "Create Flight View" feature.

The feature allows users to add new flights to the system through a web form.

We will cover:

1. The structure and layout of the form.
2. The form fields and their validation.
3. The submission and reset functionalities.

# Structure and layout of the form

<SwmSnippet path="/Client/Views/Flight/Create.cshtml" line="1">

---

The form is defined in <SwmPath>[Client/Views/Flight/Create.cshtml](/Client/Views/Flight/Create.cshtml)</SwmPath>. It uses the <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="1:7:7" line-data="@model Client.Models.Flight">`Flight`</SwmToken> model and sets the page title to "Create". The form is styled with Bootstrap classes for responsiveness.

```
@model Client.Models.Flight
@{
    ViewData["Title"] = "Create";
}

<div class="page-header">@ViewBag.Message</div>
<div class="row">
    <div class="create-flight-container col-xs-12 col-sm-12">
        <form method="post" enctype="multipart/form-data" asp-action="Create" asp-controller="Flight">
            <div class="form-header">
                <img src="~/images/nebb.png" />
                <span>Nebb Airline Add New Flight</span>
            </div>
            <div class="top-info">
                <div class="form-group">
                    <label asp-for="Origin"></label>
                    <input asp-for="Origin" />
```

---

</SwmSnippet>

# Form fields and their validation

<SwmSnippet path="/Client/Views/Flight/Create.cshtml" line="18">

---

The form includes fields for <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="24:11:11" line-data="                        &lt;span asp-validation-for=&quot;Origin&quot;&gt;&lt;/span&gt;">`Origin`</SwmToken>, <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="19:9:9" line-data="                    &lt;label asp-for=&quot;Destination&quot;&gt;&lt;/label&gt;">`Destination`</SwmToken>, <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="31:9:9" line-data="                    &lt;label asp-for=&quot;FlightCode&quot;&gt;&lt;/label&gt;">`FlightCode`</SwmToken>, and <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="34:9:9" line-data="                    &lt;label asp-for=&quot;Departure&quot;&gt;&lt;/label&gt;">`Departure`</SwmToken>. Each field has a corresponding label and input element. Validation messages are displayed next to each field.

```

                    <label asp-for="Destination"></label>
                    <input asp-for="Destination" />

                    <div class="validation-container">
                        <span></span>
                        <span asp-validation-for="Origin"></span>
                        <span></span>
                        <span asp-validation-for="Destination"></span>
                    </div>
                </div>
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Views/Flight/Create.cshtml" line="29">

---

```

                <div class="form-group">
                    <label asp-for="FlightCode"></label>
                    <input asp-for="FlightCode" />

                    <label asp-for="Departure"></label>
                    <input step="any" id="departure" asp-for="Departure" />
```

---

</SwmSnippet>

<SwmSnippet path="/Client/Views/Flight/Create.cshtml" line="36">

---

```

                    <div class="validation-container">
                        <span></span>
                        <span asp-validation-for="FlightCode"></span>
                        <span></span>
                        <span asp-validation-for="Departure"></span>
                    </div>
                </div>
            </div>
            <div class="flight-buttons">
                <input type="reset" value="Reset" id="reset" class="btn btn-danger" />
                <input type="submit" value="Add" id="submit" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>
```

---

</SwmSnippet>

# Submission and reset functionalities

<SwmSnippet path="/Client/Views/Flight/Create.cshtml" line="36">

---

The form includes "Reset" and "Add" buttons. The "Reset" button clears the form, while the "Add" button submits the form data to the <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="3:11:11" line-data="    ViewData[&quot;Title&quot;] = &quot;Create&quot;;">`Create`</SwmToken> action in the <SwmToken path="/Client/Views/Flight/Create.cshtml" pos="45:7:7" line-data="            &lt;div class=&quot;flight-buttons&quot;&gt;">`flight`</SwmToken> controller.

```

                    <div class="validation-container">
                        <span></span>
                        <span asp-validation-for="FlightCode"></span>
                        <span></span>
                        <span asp-validation-for="Departure"></span>
                    </div>
                </div>
            </div>
            <div class="flight-buttons">
                <input type="reset" value="Reset" id="reset" class="btn btn-danger" />
                <input type="submit" value="Add" id="submit" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>
```

---

</SwmSnippet>

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
