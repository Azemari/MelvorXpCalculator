function AcceptCookies() {
    document.cookie = "Consent=true; expires=Wed, 1 Jan 2025 00:00:00 UTC; path=/";
    $("#cookieBanner").slideUp();
}

function RejectCookies() {
    document.cookie = "Consent=never; expires=Wed, 1 Jan 2025 00:00:00 UTC; path=/";
    $("#cookieBanner").slideUp();
}

function UpdateGlobalModifier(_this) {
    var currentModifier = parseInt($("#Modifiers_TotalXpModifier").val());
    console.log(currentModifier);
    var modifier = parseInt(currentModifier);
    if ($(_this).is(":checked"))
        modifier = parseInt(currentModifier) + parseInt(_this.value);
    else
        modifier = $("#Modifiers_TotalXpModifier").val();
    $("#modifierDisplay").text(modifier + "% Skill XP Modifier");
}

function updateXp(_this) {
    $("#xp").val(calculateExperience(_this.value));
}

function updateLevel(_this) {
    var xp = calculateLevel(_this.value);
    $("#level").val(xp);
}

function calculateXp(_this) {
    var xp = calculateExperience(_this.value);
    $("#targetXp").val(xp);
    var difference = parseInt(targetXp) - parseInt(xp);
    $("#xpDifference").val(difference);
}

function calculateDifference(_this) {
    var currentXp = $("#xp").val();
    var targetXp = _this.value;
    var difference = parseInt(targetXp) - parseInt(currentXp);
    $("#xpDifference").val(difference);
    $("#targetLevel").val(calculateLevel(targetXp));
    //update(difference);
}

function calculateExperience(level) {
    var total = 0;
    for (var i = 1; i < level; i++)
    {
        total += Math.floor(i + 300 * Math.pow(2, i / 7.0));
    }
    return Math.floor(total / 4);
}

function calculateLevel(experience) {
    var index;
    for (index = 0; index < 120; index++) {
        if (calculateExperience(index + 1) > experience)
            break;
    }
    return index;
}

function setActivePanel(_this) {
    //Hide and unselect the currently active panel
    var activePanel = $("#smithing-nav").find('.active');
    activePanel.removeClass('active');
    $("#" + activePanel[0].id.split('-')[1] + "-Panel").hide();
    //Show and select the new panel
    $("#" + $(_this)[0].id.split('-')[1] + "-Panel").show();
    $(_this).addClass('active');
}

function update(difference) {
    $.ajax({
        url: '/Skills/Smithing',
        data: "difference=" + difference,
        type: 'GET',
        success: function (result) {
            //====From Stop and Search====
            //$('#NeighbourhoodSelect').replaceWith($('#NeighbourhoodSelect', data));
            //$("#NeighbourhoodSelect").change(function () {
            //    NeighbourhoodSelectChanged();
            //})
            //Pass the xpDifference back to the controller, and use the new data to update the calculations
        },
        error: function (passParams) {
            console.log("ERROR: " + passParams);
        }
    });
}