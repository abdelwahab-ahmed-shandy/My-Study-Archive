
📌 إرسال البيانات من الـ Controller إلى الـ View في ASP.NET Core MVC

عند التعامل مع MVC، نحتاج إلى إرسال بيانات من الـ Controller إلى الـ View حتى يتم عرضها على المستخدم.

//============================================================================================================

1️ - باستخدام ViewBag 📌 

ViewBag هو كائن ديناميكي يسمح بتمرير البيانات من Controller إلى View بدون الحاجة إلى تعريف كلاس (Model).
🔹 تُستخدم هذه الطريقة عند الحاجة لإرسال بيانات بسيطة ومؤقتة.


✔ مثال في الـ Controller:

public IActionResult Index()
{
    ViewBag.Message = "مرحبًا بك في موقعي!";
    return View();
}

✔ مثال في الـ View (Index.cshtml):

<h2>@ViewBag.Message</h2>

✅ النتيجة:
"مرحبًا بك في موقعي!" ستظهر على الصفحة.

⚠ متى نستخدمها؟

عند الحاجة لإرسال بيانات بسيطة مثل نصوص أو أرقام فقط.
او حتى بيانات داخل  Model  معين لل View 

//============================================================================================================

2️ - باستخدام ViewData 📌

🔹 ViewData هو قاموس (Dictionary) يمكنه تخزين بيانات كـ Key-Value.
🔹 يمكن استخدامه لتمرير البيانات بين Controller و View لكنه يتطلب Casting عند الاستخدام.

✔ مثال في الـ Controller:

public IActionResult Index()
{
    ViewData["Title"] = "الصفحة الرئيسية";
    ViewData["Year"] = 2025;
    return View();
}

✔ مثال في الـ View (Index.cshtml):

<h2>@ViewData["Title"]</h2>
<p>السنة: @ViewData["Year"]</p>

✅ النتيجة:
الصفحة الرئيسية
السنة: 2025


⚠ متى نستخدمها؟

عندما نحتاج إلى إرسال بيانات سريعة وصغيرة الحجم مثل النصوص أو الأرقام.


//============================================================================================================

3️ - باستخدام TempData 📌

🔹 TempData يُستخدم لنقل البيانات بين الصفحات المختلفة (بين Request و Request آخر).
🔹 يخزن البيانات مؤقتًا حتى يتم قراءتها مرة واحدة، ثم يتم حذفها تلقائيًا.


✔ مثال في الـ Controller (الإرسال):

public IActionResult Index()
{
    TempData["SuccessMessage"] = "تم تسجيل الدخول بنجاح!";
    return RedirectToAction("Dashboard");
}


✔ مثال في الـ Controller (الاستقبال في صفحة أخرى):

public IActionResult Dashboard()
{
    return View();
}


✔ مثال في الـ View (Dashboard.cshtml):

@if (TempData["SuccessMessage"] != null)
{
    <p>@TempData["SuccessMessage"]</p>
}

✅ النتيجة:

تم تسجيل الدخول بنجاح!


⚠ متى نستخدمها؟

عندما نريد نقل بيانات بين الصفحات، مثل رسائل التنبيهات (Success, Error).

//============================================================================================================
//============================================================================================================
//============================================================================================================

4️ - باستخدام Model (الأفضل) 📌

🔹 الطريقة المثالية لنقل البيانات في MVC هي استخدام Model.
🔹 يتيح تنظيم البيانات بشكل احترافي ويقلل من الأخطاء.

✔ إنشاء Model:

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


✔ مثال في الـ Controller:

public IActionResult Index()
{
    var person = new Person { Name = "أحمد", Age = 25 };
    return View(person);
}


✔ مثال في الـ View (Index.cshtml):

@model Person

<h2>الاسم: @Model.Name</h2>
<p>العمر: @Model.Age</p>


✅ النتيجة:

الاسم: أحمد
العمر: 25

⚠ متى نستخدمها؟

عند إرسال بيانات معقدة مثل الكائنات (Objects) والقوائم (List<>).

//============================================================================================================

🎯 ملخص سريع :

الطريقة					الوصف									الاستخدام الأفضل

ViewBag			كائن ديناميكي لنقل البيانات				بيانات بسيطة مثل النصوص والأرقام

ViewData		قاموس (Dictionary) لتخزين البيانات		بيانات صغيرة الحجم تحتاج إلى كاستنج

TempData		تخزين البيانات بين الـ Requests			نقل البيانات بين الصفحات مثل الرسائل

Model			كائن قوي لنقل البيانات					أفضل طريقة لإرسال البيانات المعقدة


//============================================================================================================

🚀 النصيحة:

استخدم Model قدر الإمكان، لأنه أكثر كفاءة وقابلية للصيانة.

استخدم TempData عند الحاجة إلى نقل البيانات بين الصفحات.

استخدم ViewBag و ViewData فقط للبيانات البسيطة التي لا تحتاج إلى نموذج (Model).


//==========================================================================================================================
//==========================================================================================================================
Abdelwahab Shandy
//==========================================================================================================================
//==========================================================================================================================