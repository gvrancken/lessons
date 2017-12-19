# Javascript lesson 2:smile:

##Comparisons

In programming we need to be able to make decisions in code. They allow us to control what part of a program to run and what part not to run.

Decisions are done by assessing logical value of an expression. Each expression has a value of either **true** or **false**.

###Comparators

####Equal to

```javascript
12.435 === 12.434
```

**true**



### Greater than

```js
6 > 4
```

**true**

```javascript
4 > 6
```

**false**



## Conditionals

####the *if* statement

To control if a piece of code should be run we use the **if** statement. 

```javascript
if <logical_expression> {
    // Run the code in here
}
```

It only runs the code within the parentheses **{ ... }** if the logical expression is assessed as **true**.

Let's consider the following example:

```javascript
if (10 > 12) {
    console.log("It must have been true...");
}
```

What happens here? We will not see any text displayed; and why? The browser assesses the statement *( 10 > 12 )* as **false** and therefor does not run the code inside **{ }**.

Let's modify the expression and see what happens then.

```javascript
if (10 > 5) {
    console.log("It must have been true...");
}
```

Now we can see *It must have been true...* What's happened there? The expression *( 10 > 5 )* was assessed as **true** and the code inside **{ }** was run.

#### the *if-else* variant

```javascript
if <logical_expression> {
    // Run the code in here
} else {
    // Run a different bit of code
}
```



```javscript
if (10 > 12) {
    console.log("It must have been true...");
} else {
    console.log("I guess it wasn't...");
}
```

## Loops

What if we want to run a piece of code multiple times?

### for loop

```javascript
for (var i = 1; i < 10; i++) {
    console.log(i);
}
```



###while loop

A **while** loop repeats a block of code while an expression is **true**.

```javascript
while (i < 10) {
    alert(i);
    i = i + 1;
}
```



> To be continued...







