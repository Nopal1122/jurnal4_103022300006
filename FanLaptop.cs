using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

public class FanLaptop
{
    private IFanState _currentState;

    public FanLaptop()
    {

        _currentState = new QuietState();
    }

    public void SetState(IFanState newState)
    {
        _currentState.OnStateChange(this, newState);
        _currentState = newState;
    }

    public void ChangeToTurbo()
    {
        SetState(new TurboState());
    }

    public void ChangeToBalanced()
    {
        SetState(new BalancedState());
    }

    public string GetCurrentState()
    {
        return _currentState.GetName();
    }
}

public interface IFanState
{
    void OnStateChange(FanLaptop fan, IFanState newState);
    string GetName();
}

public class QuietState : IFanState
{
    public void OnStateChange(FanLaptop fan, IFanState newState)
    {
        Console.WriteLine("Fan Quiet berubah menjadi " + newState.GetName());
    }

    public string GetName()
    {
        return "Quiet";
    }
}

public class TurboState : IFanState
{
    public void OnStateChange(FanLaptop fan, IFanState newState)
    {
        Console.WriteLine("Fan Turbo berubah menjadi " + newState.GetName());
    }

    public string GetName()
    {
        return "Turbo";
    }
}

public class BalancedState : IFanState
{
    public void OnStateChange(FanLaptop fan, IFanState newState)
    {
        Console.WriteLine("Fan Balanced berubah menjadi " + newState.GetName());
    }

    public string GetName()
    {
        return "Balanced";
    }
}

