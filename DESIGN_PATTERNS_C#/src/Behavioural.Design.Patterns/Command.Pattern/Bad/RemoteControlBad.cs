namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Bad;

//Invoker class
public class RemoteControlBad
{
    private Light _light;

    public RemoteControlBad(Light light)
    {
        _light = light;
    }

    public void PressButton(bool turnOn)
    {
        if (turnOn)
        {
            _light.TurnOn();
        }
        else
        {
            _light.TurnOff();
        }
    }

    public void DimLight()
    {
        // _light.Dim();
    }

}
