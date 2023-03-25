using Dalamud.Interface.Components;
using PunishLib.ImGuiMethods;

namespace AutoRetainer.UI.Settings;

internal static class Beta
{
    internal static void Draw()
    {
        ImGuiEx.Text(ImGuiColors.DalamudOrange, $"These features might be incomplete, cause problems, or simply not work.");
        InfoBox.DrawBox("RetainerSense", delegate
        {
            ImGui.Checkbox("RetainerSense", ref P.config.RetainerSense);
            ImGuiComponents.HelpMarker($"AutoRetainer will automatically enable itself when the player is within interaction range of a Summoning Bell. You must remain stationary or the activation will be cancelled.");
            ImGui.SetNextItemWidth(200f);
            ImGuiEx.SliderIntAsFloat("Activation Time", ref P.config.RetainerSenseThreshold, 1000, 100000);
        });
        InfoBox.DrawBox("House Enter Task", delegate
        {
            ImGui.Checkbox($"Multi Mode: Housing Bell Support", ref P.config.MultiAllowHET);
            ImGuiEx.TextWrapped(ImGuiColors.DalamudOrange, $"A Summoning Bell must be within range of the spawn point once the home is entered.");
        });
    }
}