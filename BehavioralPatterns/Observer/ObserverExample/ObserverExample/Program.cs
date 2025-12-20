using ObserverExample;

var app = new App();
var phone1 = new Mobile("MyPhone");
var phone2 = new Mobile("Tablet");

app.Subscribe(phone1);
app.Subscribe(phone2);

app.NewUpdate("1.1"); // كل الموبايلات هتستقبل إشعار