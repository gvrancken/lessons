# Javascript lesson 4

## Objects

Objects are combinations of properties and abilities and are used to represent real life objects. Javascript uses variables and functions to construct objects.

```JavaScript
var <object_name> = {
    <property_1>: value_1,
    <property_2>: value_2,
    <ability_1>: function () { //Do something
	}
}; 
```

Let's represent a colored pencil with an object.

In our example, we will focus on color and sharpness properties and the ability to sharpen.

```javascript
var pencil_1 = {
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



We've just created an object called pencil_1 representing a blue pencil which is currently blunt (not sharp).



```javascript
pencil_1.isSharp();
```

> false



We can sharpen the pencil by invoking it's **sharpen()** function.



```javascript
pencil_1.sharpen();
```



Checking sharpness of the pen will yield different value now.

```javascript
pencil_1.isSharp();
```

> true







