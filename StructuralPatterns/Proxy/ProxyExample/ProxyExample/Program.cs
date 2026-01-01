using ProxyExample;

IDocument doc1 = new DocumentProxy("User");
doc1.Open();   // Access denied

IDocument doc2 = new DocumentProxy("Admin");
doc2.Open();   // Document opened