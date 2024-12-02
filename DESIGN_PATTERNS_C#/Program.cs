using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Memento.Pattern.Good;

var editor = new Editor();
var history = new History(editor);

history.BackUp();
editor.Title = "Test";
history.BackUp();
editor.Content = "Hello there, my name is Karthik";
history.BackUp();
editor.Title = "The life of a dev: my mementos";


System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.ShowHistory();