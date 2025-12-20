
namespace DecoratorLiveExample;

/// <summary>
/// Example
/// عندك كوباية قهوة ☕
//قهوة بس

//قهوة + لبن 🥛

//قهوة + لبن + سكر 🍬

//قهوة + لبن + سكر + كراميل 🍯

//هل كل مرة نعمل كوباية جديدة؟
//❌ لا

//إحنا بنبدأ بحاجة بسيطة
//وبعدين نضيف عليها حاجات واحدة واحدة

/// </summary>
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}
