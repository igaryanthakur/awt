# ASP.NET MVC — Voter Registration

**Exam question:** Create an MVC application to accept Voter information and display the same using views. Use automatically implemented properties, strongly typed HTML Input helpers methods and apply validations.

## Folder structure
```
Controllers/VoterController.cs   — GET Register, POST Register, GET Display
Models/Voter.cs                  — Model with Data Annotations
Views/Voter/Register.cshtml      — Strongly typed form with Html helpers
Views/Voter/Display.cshtml       — Displays submitted voter info
```

## Key concepts demonstrated
| Concept | Where |
|---------|-------|
| Auto-implemented properties | `Voter.cs` |
| Data Annotations (`[Required]`, `[Range]`, `[RegularExpression]`) | `Voter.cs` |
| Strongly typed view (`@model Voter`) | Both views |
| `Html.TextBoxFor`, `Html.LabelFor`, `Html.ValidationMessageFor` | Register view |
| `Html.ActionLink` | Display view |
| `ModelState.IsValid` | Controller POST |
| `TempData` to pass model between actions | Controller |

## Same template works for
- Train ticket booking (rename properties)
- Customer data entry
