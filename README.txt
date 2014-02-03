SecondViewModel is requested as a result of an action from StartPageViewModel. 
It passes to a serialized object (ComplexObjectType) to the call, which should
be passed into `Init(string parameter)` method of the SecondViewModel as per post[1].

Note that if you put a breakpoint in the method `InitFromBundle (IMvxBundle parameters)`
this method will be called and `parameters` contains expected values.

Also tried with different approach, described here[2]. Still no-go.

[1]:http://stackoverflow.com/questions/19058173/passing-complex-navigation-parameters-with-mvvmcross-showviewmodel
[2]:https://github.com/MvvmCross/MvvmCross/wiki/ViewModel--to-ViewModel-navigation#wiki-navigation-with-parameters---using-a-parameter-object