using PrototypeExample;

WebsiteTemplate originalTemplate = new WebsiteTemplate("Corporate", 5);
originalTemplate.ShowTemplate();

// Clone for a new client and modify
WebsiteTemplate clientTemplate = (WebsiteTemplate)originalTemplate.Clone();
clientTemplate.Theme = "E-commerce";
//clientTemplate.Pages = 10;
clientTemplate.ShowTemplate();
originalTemplate.ShowTemplate();