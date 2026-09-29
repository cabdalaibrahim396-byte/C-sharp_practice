# C# Basic Code Examples

README-kan wuxuu sharxayaa qaar ka mid ah **C# Windows Forms** code-yada
muhiimka ah. Tusaalooyinku waxay ka hadlayaan **String, Variables,
ToString(), Type Casting, Try/Catch, Parse, iyo Clear()**.

------------------------------------------------------------------------

## 1. String Concatenation

``` csharp
//Example of String Concatenation
//Declaring Variable string
string message;

//concatenate of string using message variable
message = "Jamhuriya" + "University";

//Display The Output Using MessageBox
MessageBox.Show(message);
```

### Sharaxaad

Code-kan wuxuu isku daraa laba **string** oo kala duwan:

``` csharp
message = "Jamhuriya" + "University";
```

-   `string message;` → wuxuu sameynayaa variable lagu kaydinayo qoraal.
-   `"Jamhuriya"` → waa string-ka koowaad.
-   `"University"` → waa string-ka labaad.
-   `+` → wuxuu isku daraa labada string.
-   `MessageBox.Show(message);` → wuxuu soo bandhigayaa natiijada.

### Natiijo

Marka code-ka la fuliyo, MessageBox-ku wuxuu muujinayaa:

``` text
JamhuriyaUniversity
```

> Haddii aad rabto meel bannaan, waxaad isticmaali kartaa
> `"Jamhuriya " + "University"`.

------------------------------------------------------------------------

## 2. Decimal Variable iyo ToString()

``` csharp
decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();
```

### Sharaxaad

Code-kan wuxuu kaydinayaa lacag ama number decimal ah, kadibna wuxuu u
beddelayaa **string** si loogu soo bandhigo Label.

-   `decimal` → waxaa loo isticmaalaa numbers leh decimal, gaar ahaan
    lacag.
-   `grossPay` → waa magaca variable-ka.
-   `1550.0m` → waa decimal value.
-   `grossPay.ToString()` → wuxuu decimal-ka u beddelayaa string.
-   `grossPayLabel.Text` → wuxuu value-ga ku qorayaa Label-ka.

### Natiijo

Label-ka wuxuu muujinayaa:

``` text
1550.0
```

------------------------------------------------------------------------

## 3. Integer iyo ToString()

``` csharp
int myNumber = 123;

MessageBox.Show(myNumber.ToString());
```

### Sharaxaad

Code-kan wuxuu sameynayaa integer kadibna wuxuu u beddelayaa string.

-   `int` → wuxuu kaydiyaa number dhan.
-   `myNumber` → waa variable-ka.
-   `123` → waa value-ga.
-   `ToString()` → wuxuu number-ka u beddelayaa text/string.
-   `MessageBox.Show()` → wuxuu soo bandhigayaa value-ga.

### Natiijo

``` text
123
```

ayaa MessageBox-ka ka soo baxaya.

------------------------------------------------------------------------

## 4. TextBox Text

``` csharp
textBox1.Text = "Hello";
```

### Sharaxaad

Code-kan wuxuu ku qorayaa **Hello** gudaha TextBox.

-   `textBox1` → waa magaca TextBox-ka.
-   `.Text` → wuxuu tilmaamayaa qoraalka TextBox-ka.
-   `"Hello"` → waa qoraalka lagu qorayo.

### Natiijo

TextBox-ka wuxuu yeelanayaa:

``` text
Hello
```

------------------------------------------------------------------------

## 5. Type Casting: Decimal to Integer

``` csharp
int wholeNumber;
decimal moneyNumber = 4500;

wholeNumber = (int)moneyNumber;
```

### Sharaxaad

Code-kan wuxuu sameynayaa **type casting**, taas oo ah in data type laga
beddelo mid kale.

-   `int wholeNumber;` → wuxuu sameynayaa integer variable.
-   `decimal moneyNumber = 4500;` → wuxuu sameynayaa decimal variable.
-   `(int)moneyNumber` → wuxuu decimal-ka u beddelayaa integer.
-   `wholeNumber = ...` → natiijada waxaa lagu kaydinayaa `wholeNumber`.

### Tusaale

Haddii value-gu yahay:

``` text
4500.75
```

marka loo beddelo `int`:

``` text
4500
```

Qaybta decimal-ka waa la tuurayaa.

------------------------------------------------------------------------

## 6. Type Casting: Decimal to Double

``` csharp
double realNumber;
decimal moneyNumber = 625.70m;

realNumber = (double)moneyNumber;
```

### Sharaxaad

Code-kan wuxuu decimal value u beddelayaa **double**.

-   `double realNumber;` → wuxuu sameynayaa double variable.
-   `decimal moneyNumber = 625.70m;` → wuxuu kaydinayaa decimal value.
-   `(double)moneyNumber` → wuxuu decimal-ka u beddelayaa double.
-   `realNumber = ...` → wuxuu natiijada ku kaydinayaa `realNumber`.

### Natiijo

Value-ga wuxuu noqonayaa qiyaastii:

``` text
625.70
```

------------------------------------------------------------------------

## 7. Try, Parse iyo Average

``` csharp
try
{
    //Declaring Variable to store input user
    double test1, test2, test3, Average;

    //Get the three test scores
    test1 = double.Parse(txttest1.Text);
    test2 = double.Parse(txttest2.Text);
    test3 = double.Parse(txttest3.Text);

    //Calculate The Average test scores
    Average = (test1 + test2 + test3) / 3;

    //Display the average test score,
    //with the output rounded to 1 decimal point.
    lblaverage.Text = Average.ToString("n1");
}
catch (Exception ex)
{
    // Display the default error message.
    MessageBox.Show(ex.Message);
}
```

### Sharaxaad

Code-kan wuxuu qaadanayaa **3 test scores** oo user-ku ku qorayo
TextBox-yada, kadibna wuxuu xisaabinayaa average-kooda.

### 7.1 Variables

``` csharp
double test1, test2, test3, Average;
```

Waxaa la sameeyay afar `double` variables:

-   `test1` → score-ka koowaad.
-   `test2` → score-ka labaad.
-   `test3` → score-ka saddexaad.
-   `Average` → average-ka.

### 7.2 double.Parse()

``` csharp
test1 = double.Parse(txttest1.Text);
```

`txttest1.Text` wuxuu TextBox-ka ka soo qaadanayaa **text**.

`double.Parse()` wuxuu text-ka u beddelayaa **double number**.

Sidaas oo kale ayaa loo sameynayaa `test2` iyo `test3`.

### 7.3 Calculate Average

``` csharp
Average = (test1 + test2 + test3) / 3;
```

Waxay isku daraysaa saddexda score kadibna waxay u qaybinaysaa `3`.

Tusaale:

``` text
80 + 70 + 90 = 240
240 / 3 = 80
```

### 7.4 ToString("n1")

``` csharp
lblaverage.Text = Average.ToString("n1");
```

`ToString("n1")` wuxuu natiijada u format-gareeyaa **hal decimal
place**.

Tusaale:

``` text
80
```

waxay noqon kartaa:

``` text
80.0
```

### 7.5 try/catch

``` csharp
try
{
    // code
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

`try` wuxuu isku dayayaa inuu fuliyo code-ka.

`catch` wuxuu qabtaa error-ka haddii uu dhaco.

Tusaale ahaan, haddii user-ku TextBox-ka ku qoro:

``` text
abc
```

halkii uu number ka qori lahaa, `double.Parse()` wuxuu keeni karaa
error, waxaana `catch` soo bandhigi karaa fariinta error-ka.

------------------------------------------------------------------------

## 8. Clearing a TextBox

Waxaa jira dhowr hab oo TextBox loo nadiifin karo.

### Method 1: Empty String

``` csharp
textBox1.Text = "";
```

### Sharaxaad

Waxay TextBox-ka ka dhigaysaa empty string.

### Natiijo

``` text
TextBox → Empty
```

------------------------------------------------------------------------

### Method 2: string.Empty

``` csharp
textBox1.Text = string.Empty;
```

### Sharaxaad

`string.Empty` wuxuu ka dhigan yahay string aan wax qoraal ah lahayn.

Waxay leedahay natiijo la mid ah:

``` csharp
textBox1.Text = "";
```

------------------------------------------------------------------------

### Method 3: Clear()

``` csharp
textBox1.Clear();
```

### Sharaxaad

`Clear()` wuxuu si toos ah u tirtirayaa qoraalka ku jira TextBox-ka.

### Natiijo

Haddii TextBox-ku leeyahay:

``` text
Hello
```

kadib:

``` csharp
textBox1.Clear();
```

wuxuu noqonayaa:

``` text
Empty
```

------------------------------------------------------------------------

# Summary

  Code                            Waxa uu qabanayo
  ------------------------------- -------------------------------------
  `string message;`               Sameynaya string variable
  `"Jamhuriya" + "University"`    Isku daraya laba string
  `MessageBox.Show()`             Soo bandhigaya popup message
  `decimal grossPay = 1550.0m;`   Sameynaya decimal variable
  `ToString()`                    Number u beddelaya string
  `int myNumber = 123;`           Sameynaya integer variable
  `textBox1.Text = "Hello";`      TextBox ku qoraya Hello
  `(int)moneyNumber`              Decimal u beddelaya integer
  `(double)moneyNumber`           Decimal u beddelaya double
  `double.Parse()`                Text u beddelaya double
  `Average = (...) / 3`           Xisaabinaya average
  `ToString("n1")`                Number u format-gareynaya 1 decimal
  `try/catch`                     Qabanaya errors
  `textBox1.Clear()`              Nadiifinaya TextBox

------------------------------------------------------------------------

## Conclusion

Code-yadani waxay kaa caawinayaan fahamka aasaaska **C# Windows Forms**,
gaar ahaan:

-   **Variables**
-   **Strings**
-   **Integers**
-   **Decimals**
-   **Doubles**
-   **String Concatenation**
-   **Type Casting**
-   **ToString()**
-   **Parse()**
-   **Try/Catch**
-   **TextBox manipulation**
-   **MessageBox**

Waxaad isticmaali kartaa tusaalooyinkan marka aad sameynayso C# Windows
Forms applications.
