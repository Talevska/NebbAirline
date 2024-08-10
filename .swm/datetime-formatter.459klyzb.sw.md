---
title: DateTime Formatter
---
# Introduction

This document will walk you through the implementation of the <SwmToken path="/Client/Services/DateTimeFormater.cs" pos="10:7:7" line-data="        public string GetFormattedDate(DateTime dateTime)">`DateTime`</SwmToken> Formatter feature.

The feature formats dates and times into a more readable string format.

We will cover:

1. How the day of the week is formatted.
2. How the month is formatted.
3. How the final formatted date string is constructed.
4. How the time is formatted.

# Formatting the day of the week

<SwmSnippet path="/Client/Services/DateTimeFormater.cs" line="1">

---

We start by defining the <SwmToken path="/Client/Services/DateTimeFormater.cs" pos="10:5:5" line-data="        public string GetFormattedDate(DateTime dateTime)">`GetFormattedDate`</SwmToken> method, which formats the day of the week based on the <SwmToken path="/Client/Services/DateTimeFormater.cs" pos="14:6:6" line-data="            switch (dateTime.DayOfWeek)">`DayOfWeek`</SwmToken> enum.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Services
{
    public class DateTimeFormater : IDateTimeFormater
    {
        public string GetFormattedDate(DateTime dateTime)
        {
            string day;
            string month;
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    day = "Fri";
                    break;
                case DayOfWeek.Monday:
                    day = "Mon";
                    break;
                case DayOfWeek.Saturday:
                    day = "Sat";
                    break;
                case DayOfWeek.Sunday:
                    day = "Sun";
                    break;
                case DayOfWeek.Thursday:
                    day = "Thu";
                    break;
                case DayOfWeek.Tuesday:
                    day = "Tue";
                    break;
                case DayOfWeek.Wednesday:
                    day = "Wed";
                    break;
                default:
                    day = "Unknown";
                    break;
            }
```

---

</SwmSnippet>

# Formatting the month

<SwmSnippet path="/Client/Services/DateTimeFormater.cs" line="41">

---

Next, we format the month using a switch statement to convert the month number into a three-letter abbreviation.

```

            switch (dateTime.Month)
            {
                case 1:
                    month = "Jan";
                    break;
                case 2:
                    month = "Feb";
                    break;
                case 3:
                    month = "Mar";
                    break;
                case 4:
                    month = "Apr";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Jun";
                    break;
                case 7:
                    month = "Jul";
                    break;
                case 8:
                    month = "Aug";
                    break;
                case 9:
                    month = "Sep";
                    break;
                case 10:
                    month = "Oct";
                    break;
                case 11:
                    month = "Nov";
                    break;
                case 12:
                    month = "Dec";
                    break;
                default:
                    month = "Unknown";
                    break;
            }
```

---

</SwmSnippet>

# Constructing the final formatted date string

<SwmSnippet path="/Client/Services/DateTimeFormater.cs" line="84">

---

The final formatted date string is constructed by combining the day, day of the month, month, and year.

```

            return day + ", " + dateTime.Day + " " + month + " " + dateTime.Year;
        }
        public string GetFormattedTime(DateTime dateTime)
        {
            return dateTime.ToShortTimeString();
        }
    }
```

---

</SwmSnippet>

# Formatting the time

<SwmSnippet path="/Client/Services/DateTimeFormater.cs" line="84">

---

The <SwmToken path="/Client/Services/DateTimeFormater.cs" pos="87:5:5" line-data="        public string GetFormattedTime(DateTime dateTime)">`GetFormattedTime`</SwmToken> method formats the time using the <SwmToken path="/Client/Services/DateTimeFormater.cs" pos="89:5:5" line-data="            return dateTime.ToShortTimeString();">`ToShortTimeString`</SwmToken> method.

```

            return day + ", " + dateTime.Day + " " + month + " " + dateTime.Year;
        }
        public string GetFormattedTime(DateTime dateTime)
        {
            return dateTime.ToShortTimeString();
        }
    }
```

---

</SwmSnippet>

This concludes the walkthrough of the <SwmToken path="/Client/Services/DateTimeFormater.cs" pos="10:7:7" line-data="        public string GetFormattedDate(DateTime dateTime)">`DateTime`</SwmToken> Formatter feature. The implementation ensures that dates and times are presented in a consistent and readable format.

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBTmViYkFpcmxpbmUlM0ElM0FUYWxldnNrYQ==" repo-name="NebbAirline"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
