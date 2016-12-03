Bridge.merge(new System.Globalization.CultureInfo("ta-LK", true), {
    englishName: "Tamil (Sri Lanka)",
    nativeName: "தமிழ் (இலங்கை)",

    numberFormat: Bridge.merge(new System.Globalization.NumberFormatInfo(), {
        nanSymbol: "NaN",
        negativeSign: "-",
        positiveSign: "+",
        negativeInfinitySymbol: "(-) முடிவிலி",
        positiveInfinitySymbol: "(+) முடிவிலி",
        percentSymbol: "%",
        percentGroupSizes: [3,2],
        percentDecimalDigits: 2,
        percentDecimalSeparator: ".",
        percentGroupSeparator: ",",
        percentPositivePattern: 1,
        percentNegativePattern: 1,
        currencySymbol: "Rs",
        currencyGroupSizes: [3,2],
        currencyDecimalDigits: 2,
        currencyDecimalSeparator: ".",
        currencyGroupSeparator: ",",
        currencyNegativePattern: 12,
        currencyPositivePattern: 2,
        numberGroupSizes: [3,2],
        numberDecimalDigits: 2,
        numberDecimalSeparator: ".",
        numberGroupSeparator: ",",
        numberNegativePattern: 1
    }),

    dateTimeFormat: Bridge.merge(new System.Globalization.DateTimeFormatInfo(), {
        abbreviatedDayNames: ["ஞாயிறு","திங்கள்","செவ்வாய்","புதன்","வியாழன்","வெள்ளி","சனி"],
        abbreviatedMonthGenitiveNames: ["ஜன.","பெப்.","மார்.","ஏப்","மே","ஜூன்","ஜூலை","ஓக.","செப்.","ஒக்.","நவ.","டிச.",""],
        abbreviatedMonthNames: ["ஜன.","பெப்.","மார்.","ஏப்","மே","ஜூன்","ஜூலை","ஓக.","செப்.","ஒக்.","நவ.","டிச.",""],
        amDesignator: "காலை",
        dateSeparator: "-",
        dayNames: ["ஞாயிற்றுக்கிழமை","திங்கட்கிழமை","செவ்வாய்க்கிழமை","புதன்கிழமை","வியாழக்கிழமை","வெள்ளிக்கிழமை","சனிக்கிழமை"],
        firstDayOfWeek: 1,
        fullDateTimePattern: "dd MMMM yyyy HH:mm:ss",
        longDatePattern: "dd MMMM yyyy",
        longTimePattern: "HH:mm:ss",
        monthDayPattern: "d MMMM",
        monthGenitiveNames: ["ஜனவரி","பெப்ரவரி","மார்ச்","ஏப்ரல்","மே","ஜூன்","ஜூலை","ஓகஸ்ட்","செப்ரம்பர்","ஒக்ரோபர்","நவம்பர்","டிசம்பர்",""],
        monthNames: ["ஜனவரி","பெப்ரவரி","மார்ச்","ஏப்ரல்","மே","ஜூன்","ஜூலை","ஓகஸ்ட்","செப்ரம்பர்","ஒக்ரோபர்","நவம்பர்","டிசம்பர்",""],
        pmDesignator: "மாலை",
        rfc1123: "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
        shortDatePattern: "dd-MM-yyyy",
        shortestDayNames: ["ஞா","தி","செ","பு","வி","வெ","ச"],
        shortTimePattern: "HH:mm",
        sortableDateTimePattern: "yyyy'-'MM'-'dd'T'HH':'mm':'ss",
        sortableDateTimePattern1: "yyyy'-'MM'-'dd",
        timeSeparator: ":",
        universalSortableDateTimePattern: "yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
        yearMonthPattern: "MMMM yyyy",
        roundtripFormat: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.uzzz"
    })
});
