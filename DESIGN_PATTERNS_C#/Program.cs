
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Good;

var document = new Document(UserRoles.Admin);
System.Console.WriteLine(document.State);

document.Publish();
System.Console.WriteLine(document.State);

document.Publish();
System.Console.WriteLine(document.State);

document.State = new DraftState(document);

System.Console.WriteLine(document.State);
