using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample;

public class Player
{
    IAttackStrategy _attackStrategy;
    public void SetAttackStrategy(IAttackStrategy strategy)
    {
        _attackStrategy = strategy;
    }

    public void Attck()
    {
        _attackStrategy.Attack();
    }
}
