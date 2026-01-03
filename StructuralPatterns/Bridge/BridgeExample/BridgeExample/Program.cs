
using BridgeExample;

Headphone overEarWired = new OverEar(new WiredConnection());
Headphone overEarWireless = new OverEar(new WirelessConnection());
Headphone inEarWired = new InEar(new WiredConnection());
Headphone inEarWireless = new InEar(new WirelessConnection());

// ✅ تجربة كل تركيبة
overEarWired.PlayMusic();       // سماعة OverEar سلكية
overEarWireless.PlayMusic();    // سماعة OverEar لاسلكية
inEarWired.PlayMusic();         // سماعة InEar سلكية
inEarWireless.PlayMusic();      // سماعة InEar لاسلكية


// المشكله:
//عندك أنواع سماعات: OverEar 🎧 - InEar 🎧
//عندك طرق الاتصال: Wired 🔌 - Wireless 📶
//لو هنعمل كل تركيبة class لوحدها، هتبقي كتير:
//OverEar + Wired
//OverEar + Wireless
//InEar + Wired
//InEar + Wireless

//💡  الحل بال Bridge: نفصل نوع السماعة عن طريقة الاتصال