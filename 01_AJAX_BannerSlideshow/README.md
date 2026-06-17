# AJAX Banner Slideshow

**Exam question:** Design an ASP.NET web form using AJAX controls to change the banner image of online shopping site for shoes after every 5 seconds.

## Key controls used
- `ScriptManager` — required on every AJAX page
- `UpdatePanel` — wraps content for partial page refresh
- `Timer` (Interval=5000ms) — fires `Tick` event every 5 seconds
- `UpdateProgress` — shows "Loading..." during postback

## How it works
1. On first load, `Session["SlideIndex"] = 0`
2. Timer fires every 5 seconds → `Timer1_Tick` increments index
3. Only the `UpdatePanel` region re-renders, not the whole page

## To run
Create a new ASP.NET Web Application → replace Default.aspx with these files.
