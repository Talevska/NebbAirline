---
title: Flight Model Description
---
# Introduction

This document will walk you through the implementation of the Flight Controller feature.

The feature introduces a new model for handling flight data with specific validation rules.

We will cover:

1. Why we need specific validation rules for flight data.
2. How the validation rules are implemented.
3. The structure of the Flight model.

# Flight model structure

The Flight model is defined in <SwmPath>[Client/Models/Flight.cs](/Client/Models/Flight.cs)</SwmPath>. It includes properties for <SwmToken path="/Server/Models/Flight.cs" pos="12:5:5" line-data="        public int FlightID { get; set; }">`FlightID`</SwmToken>, <SwmToken path="/Server/Models/Flight.cs" pos="18:5:5" line-data="        public string FlightCode { get; set; }">`FlightCode`</SwmToken>, Origin, Destination, and Departure. Each property has specific validation attributes to ensure data integrity.

# Flight code validation

<SwmSnippet path="/Client/Models/Flight.cs" line="13">

---

The <SwmToken path="/Server/Models/Flight.cs" pos="18:5:5" line-data="        public string FlightCode { get; set; }">`FlightCode`</SwmToken> property requires exactly 6 characters and uses a custom validation attribute `FlightCodeValidation` to enforce a specific format.

```

        [Display(Name = "Flight Code #:")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Flight Code # must contain exactly 6 characters")]
        [FlightCodeValidation(ErrorMessage = "ex. SK1234")]
        [Required(ErrorMessage = "Please enter Flight Code #")]
        public string FlightCode { get; set; }

        [Display(Name = "Origin:")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Origin")]
        public string Origin { get; set; }
```

---

</SwmSnippet>

# Origin and destination validation

<SwmSnippet path="/Client/Models/Flight.cs" line="25">

---

Both Origin and Destination properties require between 3 and 15 characters and only allow letters. They use the `AllLettersValidation` attribute to enforce this rule.

```

        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [Display(Name = "Destination:")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Destination")]
        public string Destination { get; set; }

        [Display(Name = "Departure:")]
        [Required(ErrorMessage = "Please enter Departure date and time")]
        [ValidDateValidation(ErrorMessage = "Invalid Date of Departure")]
        [DataType(DataType.DateTime)]
        public DateTime Departure { get; set; }
    }
}
```

---

</SwmSnippet>

# Departure date validation

<SwmSnippet path="/Client/Models/Flight.cs" line="25">

---

The Departure property requires a valid date and time. It uses the `ValidDateValidation` attribute to ensure the date is valid.

```

        [StringLength(15, MinimumLength = 3, ErrorMessage = "[3-15] characters")]
        [Display(Name = "Destination:")]
        [AllLettersValidation(ErrorMessage = "Only letters")]
        [Required(ErrorMessage = "Please enter Destination")]
        public string Destination { get; set; }

        [Display(Name = "Departure:")]
        [Required(ErrorMessage = "Please enter Departure date and time")]
        [ValidDateValidation(ErrorMessage = "Invalid Date of Departure")]
        [DataType(DataType.DateTime)]
        public DateTime Departure { get; set; }
    }
}
```

---

</SwmSnippet>

# Conclusion

This implementation ensures that all flight data adheres to specific rules, preventing invalid data from being processed. The custom validation attributes provide clear error messages to guide users in entering correct information.

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
