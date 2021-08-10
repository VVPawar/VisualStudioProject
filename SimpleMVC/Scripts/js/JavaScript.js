function myFunction() {
	var x = document.getElementById("P_Address").required;
}
function copy() {
	var checkBox = document.getElementById("Address_Copy");
	if (checkBox.checked == true) {
		document.getElementById("T_Address").value = document.getElementById("P_Address").value;
		document.getElementById("T_City").value = document.getElementById("P_City").value;
		document.getElementById("T_State").value = document.getElementById("P_State").value;
		document.getElementById("T_pin").value = document.getElementById("P_pin").value;
		document.getElementById("T_Country").value = document.getElementById("Nationalityid").value;
	}
	else {
		document.getElementById("T_Address").value = "";
		document.getElementById("T_City").value = "";
		document.getElementById("T_State").value = "";
		document.getElementById("T_pin").value = "";
		document.getElementById("T_Country").value = "";
	}
	var checkBox1 = document.getElementById("SiblingCheckbox");
	if (checkBox1.checked == true) {
		$('#SiblingId').show();

	}
	else {
		$('#SiblingId').hide();
	}
	return true;
}
function SubmitFunction() {
	var checkBox1 = document.getElementById("AgreeId");
	if (checkBox1.checked == true) {
		$('#submitId').show();
	}
	else {
		$('#submitId').hide();
	}

	return true;
}
function check() {
	var Student_Type = document.getElementById("Student_Type");
	var AcademicID = document.getElementById("AcademicID");
	if (((Student_Type.value == "DAY_SCHOLAR" || Student_Type.value == "HOSTEL") && AcademicID.value == "-1") || (Student_Type.value == "" && AcademicID.value == "2021-22")) {
		document.getElementById("Class_S").innerHTML = "--Not Eligible--";

	}

	if (Student_Type.value == "DAY_SCHOLAR" && AcademicID.value == "2021-22") {
		document.getElementById("Class_S").innerHTML = "--Select Class--";
		$('#Class2').show();
		$('#Class3').show();
		$('#Class4').show();
		$('#Class5').show();
		$('#Class6').show();
		$('#Class7').show();
		$('#Class8').show();
		$('#Class9').show();
		$('#Class10').show();
		$('#Class11').show();
		$('#Class12').show();
		$('#Class13').show();
		$('#Class14').show();
		$('#Class15').show();

	}
	else {
		//document.getElementById("Class_S1").innerHTML="";
		$('#Class2').hide();
		$('#Class3').hide();
		$('#Class4').hide();
		$('#Class5').hide();
		$('#Class6').hide();
		$('#Class7').hide();
		$('#Class8').hide();
		$('#Class9').hide();
		$('#Class10').hide();
		$('#Class11').hide();
		$('#Class12').hide();
		$('#Class13').hide();
		$('#Class14').hide();
		$('#Class15').hide();
	}
	if (Student_Type.value == "HOSTEL" && AcademicID.value == "2021-22") {
		document.getElementById("Class_S").innerHTML = "--Select Class--";
		$('#Class15').show();
		$('#Class16').show();
		$('#Class17').show();
		$('#Class18').show();
		$('#Class19').show();
		$('#Class20').show();

	}
	else {
		//document.getElementById("Class_S").innerHTML="";

		$('#Class15').hide();
		$('#Class16').hide();
		$('#Class17').hide();
		$('#Class18').hide();
		$('#Class19').hide();
		$('#Class20').hide();
	}
	if (Student_Type.value == "" && AcademicID.value == "-1") {
		document.getElementById("Class_S").innerHTML = "";
	}
	return true;
}

$(document).ready(function () {
	$('#ModerniteId').change(function () {
		if ($('#ModerniteId').val() == 'Yes') {
			$('#Modernite_Y').show();
			$('#Modernite_B').show();
			$('#Modernite_year').show();
			$('#Modernite_Branch').show();
		}
		else {
			$('#Modernite_Y').hide();
			$('#Modernite_B').hide();
			$('#Modernite_year').hide();
			$('#Modernite_Branch').hide();
		}
	});
	$('#ModerniteIdF').change(function () {
		if ($('#ModerniteIdF').val() == 'Yes') {
			$('#Modernite_YF').show();
			$('#Modernite_BF').show();
			$('#Modernite_yearF').show();
			$('#Modernite_BranchF').show();
		}
		else {
			$('#Modernite_YF').hide();
			$('#Modernite_BF').hide();
			$('#Modernite_yearF').hide();
			$('#Modernite_BranchF').hide();
		}
	});
});