---
title: FlightView Component
---
<SwmSnippet path="Client/ViewComponents/FlightViewComponent.cs" line="1">

---

This code defines a `FlightViewComponent` class that extends the `ViewComponent` class. It contains a method named `Invoke` that takes a `Flight` object as an argument. The `Invoke` method returns a view named 'Flight' and passes the `flight` object to the view.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.ViewComponents
{
    public class FlightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Flight flight)
        {
            return View("Flight", flight);
        }
    }
}
```

---

</SwmSnippet>

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
