namespace MarketScientists.Widgets.Abstractions;

public interface IWidget
{
    string Title { get; }
    string Description { get; }
    IEnumerable<Category> Categories { get; }
}