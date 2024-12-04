namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Iterator.Pattern.Good;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}
