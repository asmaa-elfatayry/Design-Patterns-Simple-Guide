
using StrategyExample;

var player = new Player();
player.SetAttackStrategy(new SwordAttack());
player.Attck();

player.SetAttackStrategy(new GunAttack());
player.Attck();

player.SetAttackStrategy(new MagicAttack());
player.Attck();