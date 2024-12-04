
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

ShoppingListBad shoppingListBad = new ShoppingListBad();

shoppingListBad.Push("Milk");
shoppingListBad.Push("Bread");
shoppingListBad.Push("Mutton");

ShoppingListGood shoppingListGood = new ShoppingListGood();
shoppingListGood.Push("Milk");
shoppingListGood.Push("Bread");
shoppingListGood.Push("Mutton");

var iterator = shoppingListGood.CreateIterator();

while (iterator.HasNext())
{
    System.Console.WriteLine(iterator.Current());
    iterator.Next();
}