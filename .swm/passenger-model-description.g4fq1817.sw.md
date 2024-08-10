---
title: Passenger Model Description
---
# Introduction

This document will walk you through the implementation of the Passenger model.

The Passenger model is designed to encapsulate the data and validation logic for passenger information in the system.

We will cover:

1. The structure of the Passenger model.
2. The validation rules applied to each property.
3. The rationale behind the chosen validation rules.

# Structure of the Passenger model

<SwmSnippet path="/Client/Models/Passenger.cs" line="1">

---

The Passenger model is defined in <SwmPath>[Client/Models/Passenger.cs](/Client/Models/Passenger.cs)</SwmPath>. It includes properties for storing passenger information such as ID, first name, last name, date of birth, and passport number.

```
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Client.Validators;

namespace Client.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }
```

---

</SwmSnippet>

# Validation rules for properties

Each property in the Passenger model has specific validation rules to ensure data integrity.

## First name and last name

<SwmSnippet path="/Client/Models/Passenger.cs" line="13">

---

The first name and last name properties have the following validation rules:

- Display name for UI purposes.
- String length constraints to ensure names are between 3 and 12 characters for the first name, and 3 and 15 characters for the last name.
- Custom validation to ensure only letters are allowed.
- Required field validation to ensure these fields are not left empty.

```

        [Display(Name = "First Name:")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "[3-12] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }
```

---

</SwmSnippet>

## Date of birth and passport number

<SwmSnippet path="/Client/Models/Passenger.cs" line="25">

---

The date of birth and passport number properties have the following validation rules:

- Display name for UI purposes.
- Custom date validation to ensure the date is valid.
- Required field validation to ensure these fields are not left empty.
- Data type specification for the date of birth to ensure it is treated as a date.
- String length constraint for the passport number to ensure it is exactly 8 characters.
- Custom passport validation to ensure the format is correct.

```

        [Display(Name = "Date of Birth:")]
        [ValidDateValidation(ErrorMessage = "Invalid date")]
        [Required(ErrorMessage = "Please enter Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateBirth { get; set; }

        [Display(Name = "Passport #:")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Passport must contain exactly 8 characters")]
        [PassportValidation(ErrorMessage ="ex. B1234567")]
        [Required(ErrorMessage = "Please enter Passport #")]
        public string Passport { get; set; }
    }
}
```

---

</SwmSnippet>

# Conclusion

The Passenger model is designed to ensure that all passenger data is validated correctly before being processed. The validation rules are in place to maintain data integrity and provide meaningful error messages to the user.

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
