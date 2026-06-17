# State Management — Page Visit Counter

**Exam question:** Display the number of times current page is visited using View State, Session, Cookies and Application State.

## All 4 state types in one page

| State Type | Storage | Scope | Lifetime |
|-----------|---------|-------|----------|
| ViewState | Hidden field in HTML | This page, this tab | Until page/tab closes |
| Session | Server memory | Per user, all pages | Until browser closes (20 min default) |
| Cookie | Browser | Per user, all pages | Configurable (here: 7 days) |
| Application | Server memory | ALL users | Until app pool restarts |

## Key code patterns
```csharp
// ViewState
ViewState["key"] = value;
var x = (int)ViewState["key"];

// Session
Session["key"] = value;
var x = (int)Session["key"];

// Cookie
HttpCookie c = new HttpCookie("name", "value");
c.Expires = DateTime.Now.AddDays(7);
Response.Cookies.Add(c);
var val = Request.Cookies["name"].Value;

// Application (always lock!)
Application.Lock();
Application["key"] = value;
Application.UnLock();
```
