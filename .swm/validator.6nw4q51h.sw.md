---
title: Validator
---
# Introduction

This document will walk you through the implementation of the "Validator" feature.

The feature introduces a custom validation attribute to ensure that a string contains only letters.

We will cover:

1. Why a custom validation attribute was needed.
2. How the custom validation attribute was implemented.
3. How the custom validation attribute integrates with the existing system.

# Why a custom validation attribute was needed

The existing validation mechanisms did not provide a straightforward way to ensure that a string contains only letters. This necessitated the creation of a custom validation attribute.

# How the custom validation attribute was implemented

<SwmSnippet path="/Client/Validators/AllLettersValidationAttribute.cs" line="1">

---

We created a new class <SwmToken path="/Client/Validators/AllLettersValidationAttribute.cs" pos="9:5:5" line-data="    public class AllLettersValidationAttribute : ValidationAttribute">`AllLettersValidationAttribute`</SwmToken> that inherits from <SwmToken path="/Client/Validators/AllLettersValidationAttribute.cs" pos="9:9:9" line-data="    public class AllLettersValidationAttribute : ValidationAttribute">`ValidationAttribute`</SwmToken>. This class overrides the <SwmToken path="/Client/Validators/AllLettersValidationAttribute.cs" pos="11:7:7" line-data="        public override bool IsValid(object value)">`IsValid`</SwmToken> method to check if the input string contains only letters.

```
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Validators
{
    public class AllLettersValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ((string)value).All(Char.IsLetter);
        }
    }
}
```

---

</SwmSnippet>

# How the custom validation attribute integrates with the existing system

The <SwmToken path="/Client/Validators/AllLettersValidationAttribute.cs" pos="9:5:5" line-data="    public class AllLettersValidationAttribute : ValidationAttribute">`AllLettersValidationAttribute`</SwmToken> can now be used as a data annotation on any string property in the models to enforce the all-letters constraint. This ensures that any input data adheres to the specified validation rule, improving data integrity.

This concludes the walkthrough of the "Validator" feature implementation.

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
