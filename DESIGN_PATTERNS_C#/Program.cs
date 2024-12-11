
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Bad;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good.Undoable;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Iterator.Pattern.Bad;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Iterator.Pattern.Good;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Good;
using DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

// var document = new Document(UserRoles.Admin);
// System.Console.WriteLine(document.State);

// document.Publish();
// System.Console.WriteLine(document.State);

// document.Publish();
// System.Console.WriteLine(document.State);

// document.State = new DraftState(document);

// System.Console.WriteLine(document.State);


// ICompressor compressor = new CompressorMP4();
// IOverlay overlay = new OverlayBlackAndWhite();

// VideoStorageGood videoStorage = new VideoStorageGood(compressor, overlay);

// videoStorage.Store("/videos/some-movie");

// videoStorage.SetCompressor(new CompressorWebm());
// videoStorage.SetOverlay(new OverlayNone());

// videoStorage.Store("/videos/some-movie");

// ShoppingListBad shoppingListBad = new ShoppingListBad();

// shoppingListBad.Push("Milk");
// shoppingListBad.Push("Bread");
// shoppingListBad.Push("Mutton");

// ShoppingListGood shoppingListGood = new ShoppingListGood();
// shoppingListGood.Push("Milk");
// shoppingListGood.Push("Bread");
// shoppingListGood.Push("Mutton");

// var iterator = shoppingListGood.CreateIterator();

// while (iterator.HasNext())
// {
//     System.Console.WriteLine(iterator.Current());
//     iterator.Next();
// }

// Light light = new Light();
// RemoteControlBad remoteControlBad = new RemoteControlBad(light);

// LightGood lightGood = new LightGood();

// TurnOnCommand turnOnCommand = new TurnOnCommand(lightGood);
// TurnOffCommand turnOffCommand = new TurnOffCommand(lightGood);
// DimCommand dimLightCommand = new DimCommand(lightGood);

// RemoteControlGood remoteControlGood = new RemoteControlGood(turnOnCommand);

// remoteControlGood.PressButton();//Light is on

// remoteControlGood.SetCommand(turnOffCommand);
// remoteControlGood.PressButton();//Light is off

// remoteControlGood.SetCommand(dimLightCommand);
// remoteControlGood.PressButton();//Light is dim

var htmlDoc = new HTMLDocument();
var history = new History();
var undoCommand = new UndoCommand(history);

var italicCommand = new ItalicCommand(htmlDoc, history);
htmlDoc.Content = "Amma";
System.Console.WriteLine(htmlDoc.Content);
italicCommand.Execute();
System.Console.WriteLine($"italic-command : {htmlDoc.Content}");
undoCommand.Execute();
System.Console.WriteLine(htmlDoc.Content);


