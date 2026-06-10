namespace Teleprompter.Models;

public class TeleprompterModel
{
    public string? Text { get; set; }
    public int FontSize { get; set; } = 24;
    public double Speed { get; set; } = 1.0; // Scroll speed multiplier
    public bool IsPaused { get; set; } = true;
}
