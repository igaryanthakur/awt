# WCF Service — Arithmetic Calculator

**Exam question:** Design Web Application to create and Consume a WCF Service for addition, subtraction, division and multiplication of two numbers. Also includes area of circle and triangle.

## Files
- `ICalculatorService.cs` — ServiceContract interface
- `CalculatorService.svc` + `.cs` — WCF service implementation
- `Default.aspx` + `.cs` — web client consuming the service
- `Web.config` — WCF binding configuration

## Key WCF attributes
| Attribute | Purpose |
|-----------|---------|
| `[ServiceContract]` | Marks interface as WCF service |
| `[OperationContract]` | Marks method as exposed operation |
| `serviceMetadata httpGetEnabled="true"` | Enables WSDL at `?wsdl` |

## Operations exposed
Add, Subtract, Multiply, Divide, AreaOfCircle, AreaOfTriangle
