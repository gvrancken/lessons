# Javascript lesson 4

## Objects

Have a look at this example code:

```javascript
var pencilColor = "blue"
var pencilIsSharp = false
var sharpenPencil = function () {
   pencilIsSharp = true  
}
var IsPencilSharp = function() {
   return pencilIsSharp
}
```

We use many global variables to describe a certain object.
To organise this data, we can put all these variables inside a 'pencil' object.
Javascript uses variables and functions to construct objects.

```JavaScript
var <object_name> = {
    <property_1>: value_1,
    <property_2>: value_2,
    <ability_1>: function () { //Do something
	}
}; 
```

In our example, we will focus on color and sharpness properties and the ability to sharpen.

```javascript
var pencil = {
    color: "blue",
    sharp: false,
    sharpen: function () {
  		this.sharp = true;
	},
  	isSharp: function () {
  		return this.sharp;
	}
};  
```

We've just created an object called `pencil` representing a blue pencil which is currently blunt (not sharp).


```javascript
pencil.isSharp();
```

> false


We can sharpen the pencil by invoking it's `sharpen()` function.



```javascript
pencil.sharpen();
```

Checking sharpness of the pen will yield different value now.

```javascript
pencil.isSharp();
```

> true







