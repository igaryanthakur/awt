# XML Web Service — Palindrome Checker

**Exam question:** Create XML web service to check whether entered string is palindrome or not. And consume it using web client.

## Files
- `PalindromeService.asmx` + `.cs` — the web service with 3 WebMethods
- `Default.aspx` + `.cs` — the web client page that consumes it

## WebMethods exposed
| Method | Input | Output |
|--------|-------|--------|
| `IsPalindrome(string)` | any string | `bool` |
| `ReverseString(string)` | any string | reversed `string` |
| `StringLength(string)` | any string | `int` |

## How to add Web Reference (for real proxy consumption)
1. Right-click project → Add → Service Reference → Advanced → Add Web Reference
2. URL: `http://localhost:PORT/PalindromeService.asmx`
3. Namespace: `PalindromeRef`
4. Uncomment Option A in `Default.aspx.cs`

## Same template works for
- Area of rectangle / multiplication (replace methods)
- Square and cube of number (replace methods)
