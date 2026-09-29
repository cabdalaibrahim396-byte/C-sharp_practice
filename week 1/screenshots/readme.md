Haa saaxiib. Waxaan ka soo saaray **code-ka ku qoran screenshots-ka** oo waxaan kuu diyaariyey sharaxaad fudud oo aad si toos ah ugu gelin karto `README.md`:

 # C# Code Explanation

 ## 1\. Message Button

```
private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

 **Sharaxaad:**\
 Code-kan wuxuu shaqaynayaa marka `messageButton` la gujiyo.

 - `messageButton_Click` → waa event-ka dhaca marka button-ka la gujiyo.
- `MessageBox.Show()` → wuxuu soo bandhigayaa fariin popup ah.
- `"Hello World"` → waa fariinta ka muuqanaysa popup-ka.

 **Natiijo:** Marka button-ka la gujiyo, waxaa soo baxaya **Hello World**.

---

 ## 2\. Application Exit

```
Application.Exit;
```

 **Sharaxaad:**\
 Code-kan waxaa loogu talagalay in lagu joojiyo application-ka.

 Haddii `Application.Exit` uu yahay method-ka C# ee caadiga ah, syntax-ka saxda ahi waa:

```
Application.Exit();
```

 `Application.Exit()` wuxuu xirayaa dhammaan Windows Forms-ka application-ka.

---

 ## 3\. Logo PictureBox

```
private void logobicurebox_Click(object sender, EventArgs e)
{
    MessageBox.Show("welcome best class");
}
```

 **Sharaxaad:**\
 Code-kan wuxuu shaqaynayaa marka `logobicurebox` la gujiyo.

 - `logobicurebox_Click` → event-ka dhaca marka logo-ga la gujiyo.
- `MessageBox.Show()` → wuxuu soo bandhigayaa popup.
- `"welcome best class"` → waa fariinta popup-ka.

 **Natiijo:** Marka logo-ga la gujiyo, waxaa soo baxaya:

 > **welcome best class**

---

 ## 4\. Student PictureBox

```
private void studentpicturebox_Click(object sender, EventArgs e)
{
    studentpicturebox.Visible = false;
}
```

 **Sharaxaad:**\
 Code-kan wuxuu shaqaynayaa marka `studentpicturebox` la gujiyo.

```
studentpicturebox.Visible = false;
```

 `Visible` wuxuu xakameeyaa muuqashada control-ka.

 - `true` → PictureBox-ku wuu muuqanayaa.
- `false` → PictureBox-ku wuu qarsoomayaa.

 **Natiijo:** Marka sawirka student-ka la gujiyo, sawirku **wuu qarsoomayaa**.

---

 ## 5\. Close Form

```
this.Close();
```

 **Sharaxaad:**\
 Code-kan wuxuu xirayaa **Form-ka hadda furan**.

 - `this` → wuxuu tilmaamayaa Form-ka hadda shaqaynaya.
- `Close()` → wuxuu xirayaa Form-ka.

 **Natiijo:** Marka `this.Close();` la fuliyo, Form-ka ayaa xirmaya.

---

 ## Summary

 | Code | Waxa uu qabanayo |
| --- | --- |
| `MessageBox.Show("Hello World");` | Soo bandhigaya fariin |
| `Application.Exit();` | Xiraya application-ka |
| `MessageBox.Show("welcome best class");` | Soo bandhigaya fariin marka logo la gujiyo |
| `studentpicturebox.Visible = false;` | Qarinaaya Student PictureBox |
| `this.Close();` | Xiraya Form-ka hadda furan |

### Event Handler

 Code-yada sida:

```
private void messageButton_Click(object sender, EventArgs e)
```

 waxaa loo yaqaan **Event Handler**. Waa code la fuliyo marka user-ku sameeyo action, tusaale ahaan **button ama picture box inuu gujiyo**.