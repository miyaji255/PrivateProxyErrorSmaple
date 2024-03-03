using ClassLibrary;
using PrivateProxy;

// error CS1061: 'Class1' に 'AsPrivateProxy' の定義が含まれておらず、型 'Class1' の最初の引数を受け付けるアクセス可能な拡張メソッド 'AsPrivateProxy' が見つかりませんでした。
var proxy = new Class1().AsPrivateProxy();
proxy.Property = 1;

[GeneratePrivateProxy(typeof(Class1))]
partial struct Class1Proxy;
