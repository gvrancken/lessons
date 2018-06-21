 <?php
    $output_to_file = $_POST["voornaam"] . "\n";
    // dit is een line comment, dit wordt genegeerd door de 
    // PHP interpreter. 
    // Let op: "\n" is een newline character. Dit is equivalent met <br> in HTML.
    /*
    dit is een block 
    comment
    */
    $f = fopen("test.txt", "a"); // open file met 'append' (erbij plakken)
    fwrite($f, $output_to_file);
    fclose($f);
?>
        
<html>
    <body>

        <h1>Hallo <?php print $_POST["voornaam"]; ?>! </h1>

        <form action="form.php" method="post">
          
            Voornaam: <input name="voornaam" type="text" style="border-color:black;" value="<?php print $_POST["voornaam"]; ?>"/>
            
            <input name="vinkje" type="date" <?php if ($_POST["vinkje"] == "on") print "checked"; ?> >dit is leuk
        
            <input type="submit" value="Verstuur" />
        </form>
       
    </body>
</html>


