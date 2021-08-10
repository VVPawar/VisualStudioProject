<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SchoolRegistrationForm.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration From</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link href="CSS/Style.css" rel="stylesheet" />
    <script src="js/JavaScript.js"></script>
</head>
<body class="center main-page">
    <form id="form1" runat="server">
		<table  class="page-container" style="padding-left:20px;padding-right:20px;">
			<tr><td style="height:150px;">
				<table class="panel-1">
					<tr class="panel-1">
						<td width=10% style="padding-bottom:90px;">
							<img class="icon-panel" src="imag/logo.png"/>
						</td>
						<td class="content-1">
							<h4 class="text-1" style="color:black; padding-top:10px;">Loknete Hon. Hanmantrao Patil Charitable Trust's</h4>
							<h1 class="text-1">Adarsh Public School, Vita</h1>
							<h4 class="text-1" style="color:black;">Email:adarshcbse2009@gmail.com</h4>
							<h4 class="text-1" style="color:black;">Phone No.:+91 7559320702</h4>
							<h1 class="text-1">Registration From</h1>
							<span class="text-2" style="color:black">Note: All '<span style="color:red;">*</span>' marked fields are mandatory. Please mention '<span style="color:red;">NA</span>' if not applicable.</span>
							<br /><span class="text-2" style="font-size:30px; color:red; font-weight:bold;"> &#128073;</span>
							<a class="blink_me" style="color:red;text-decoration:none;" href="#"><blink>Proceed for Payment If Application form Already Filled.</blink></a>
						</td>
					</tr>
				</table>
			</td></tr>
			<tr ><td class="blue-panel" >
				<Span style="padding-left:5px;">Sibling Details:</span>
			</td></tr>
			<tr style="padding-left:5px;height:20px;padding-bottom:50px;"><td style="padding-bottom:20px;padding:0px;margin:0px;">
				<span style="padding-left:10px;font-size:12px;">Sibling (Real Brother/ Sister) only studying in <b>THE MODERN SCHOOL, ECNCR</b><input type="checkbox" id="SiblingCheckbox" onclick="return copy(this.from)"/></span>
				<br />
				<table style="display:none;" id="SiblingId" runat="server">
					<tr>
						<td width=25%><br /><br />
							<label  style="padding:10px;">Admission No.</label><br /><br /><br />
							<label  style="padding:10px;">Sibling Class</label><br /><br /><br />
						</td>
						<td width=25%><br />
							<input id="Admission_No" type="text" style="width:200px;" runat="server" pattern="[0-9]{4}"/><br /><br />
							<input id="Sibling_class" type="text" style="width:200px;" runat="server"  /><br /><br />
						</td>
						<td width=25% style="padding-left:100px;">
							<label style="padding:10px;">Sibling Name </label><br /><br /><br />
						</td>
						<td>
							<input style="width:200px;" type="text" id="Sibling_Name" runat="server" /><br /><br /><br />
						</td>
					</tr>
				</table>
				<br />
			</td></tr>
			<tr style="padding-top:20px;padding-left:20px;"><td class="blue-panel" style="padding-left:5px;">Student Details:</td></tr>
			<tr style="height:200px;"><td>
				<table>
					<tr>
						<td width=25% >
							<label style="padding:10px;">Student First Name<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Last Name<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Date of birth<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Student Type<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Mother tongue</label><br /><br /><br />
							<label style="padding:10px;">Religion</label><br /><br /><br />
							<label style="padding:10px;">Mobile No.<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Nationality<span style="color:red;">*</span></label><br /><br /><br />
						</td>
						<td width=25%><br />
							<span style="padding-left:60px;"><input id="F_Name" style="width:200px;" type="text" runat="server" pattern="[a-z A-Z]+" title="Student First Name should only contain letters. e.g. john" required /></span><br /><br /><br />
							<span style="padding-left:60px;"><input id="L_Name" style="width:200px;" type="text" runat="server" pattern="[a-z A-Z]+" title="Last Name should only contain letters. e.g. john" required /></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="date" id="Dob"  /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="S_Type" id="Student_Type" runat="server" onclick="return check(this.from)"  required>
									<option value="" >  --Select Student Type--  </option>
									<option value="DAY_SCHOLAR">DAY SCHOLAR</option>
									<option value="HOSTEL">HOSTEL</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;" ><input style="width:200px;"  id="MotherT" runat="server" pattern="[a-z A-Z]+" title="should only contain letters. e.g. English" /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Religion" id="Religionid" runat="server" required>
									<option value="" >  --Select Religion--  </option>
									<option value="Muslim">Muslim</option>
									<option value="Sikh">Sikh</option>
									<option value="Chrisrian">Chrisrian</option>
									<option value="Buddhist">Buddhist</option>
									<option value="Jainism">Jainism</option>
									<option value="Others">Others</option>
									<option value="Hindu">Hindu</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="phs" runat="server" required pattern="[0-9]{10}" title="Please enter a valid Mobile number"/></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;padding:10px;" name="Nationality" id="Nationalityid" runat="server" required>
									<option value="" >  --Select Nationality--  </option>
									<option value="INDIAN">INDIAN</option>
									<option value="AFGHAN">AFGHAN</option>
									<option value="ALBANIAM">ALBANIAM</option>
									<option value="ALGERIAN">ALGERIAN</option>
									<option value="AMERICAN">AMERICAN</option>
									<option value="AUSTRALIAN">AUSTRALIAN</option>
									<option value="AUSTRIAN">AUSTRIAN</option>
								</select>
							</span><br /><br /><br />
						</td>
						<td width=25% style="padding:20px;">
							<label style="padding:10px;">Middle Name</label><br /><br /><br />
							<label style="padding:10px;">Gender<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Academic Year<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Class<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Email Id<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Previous School (if any)</label><br /><br /><br />
							<label style="padding:10px;">Telephone(Resi)</label><br /><br /><br />
							<label style="padding:10px;">Student Photo</label><br /><br /><br />
						
						</td>
						<td width=25%>
							<span style="padding-left:60px;"><input id="M_name" type="text" style="width:200px;" runat="server" pattern="[a-z A-Z]+" title="should only contain letters. e.g. john"/></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Selectgender" id="Selectgenderid" runat="server" required>
									<option value="" > --Select Gender-- </option>
									<option value="Male">Male</option>
									<option value="Female">Female</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Academic" id="AcademicID" runat="server" onclick="return check(this.from)" required>
									<option value="-1" >  --Select Academic Year--  </option>
									<option value="2021-22">2021-22</option>
									
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="ClassName" id="Classid" runat="server" required>
									<option value="-1" id="Class_S"></option>
									<option value="2" style="display:none;" id="Class2">NURSERY(2021-22)</option>
									<option value="3" style="display:none;" id="Class3">KG(2021-22)</option>
									<option value="4" style="display:none;" id="Class4">CLASS-|(2021-22)</option>
									<option value="5" style="display:none;" id="Class5">CLASS-||(2021-22)</option>
									<option value="6" style="display:none;" id="Class6">CLASS-|||(2021-22)</option>
									<option value="7" style="display:none;" id="Class7">CLASS-|V(2021-22)</option>
									<option value="8" style="display:none;" id="Class8">CLASS-V(2021-22)</option>
									<option value="9" style="display:none;" id="Class9">CLASS-V|(2021-22)</option>
									<option value="10" style="display:none;" id="Class10">CLASS-V||(2021-22)</option>
									<option value="11" style="display:none;" id="Class11">CLASS-V|||(2021-22)</option>
									<option value="12" style="display:none;" id="Class12">CLASS-|X(2021-22)</option>
									<option value="13" style="display:none;" id="Class13">CLASS-X(2021-22)</option>
									<option value="14" style="display:none;" id="Class14">CLASS-X|(2021-22)</option>
									<option value="15" style="display:none;" id="Class15">CLASS-V|(HOSTEL)2021-22</option>
									<option value="16" style="display:none;" id="Class16">CLASS-V||(HOSTEL)2021-22</option>
									<option value="17" style="display:none;" id="Class17">CLASS-V|||(HOSTEL)2021-22</option>
									<option value="18" style="display:none;" id="Class18">CLASS-|X(HOSTEL)2021-22</option>
									<option value="19" style="display:none;" id="Class19">CLASS-X(HOSTEL)2021-22</option>
									<option value="20" style="display:none;" id="Class20">CLASS-X|(HOSTEL)2021-22</option>
									
									
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="EmID" runat="server" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"  required /></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="PS" runat="server"/></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="Ts" runat="server"/></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="file" id="fi" runat="server"/></span><br /><br /><br />
							
						</td>
					</tr>
				</table>
			</td></tr>
			<tr><td class="blue-panel" style="padding-left:5px;">Permant Address:</td></tr>
			<tr><td>
				<table>
					<tr>
						<td width=25%><br /><br />
							<label  style="padding:10px;">Address<span style="color:red;">*</span></label><br /><br /><br />
							<label  style="padding:10px;">State<span style="color:red;">*</span></label><br /><br /><br />
						</td>
						<td width=25%><br />
							<textarea name="address"  style="width:200px" id="P_Address" runat="server" required> </textarea><br /><br />
							<input style="width:200px;" type="text" id="P_State" runat="server" required/><br /><br />
						</td>
						<td width=25% style="padding-left:100px;"><br /><br />
							<label style="padding:10px;">City<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Pin Code<span style="color:red;">*</span></label><br /><br /><br />
						</td>
						<td>
							<input style="width:200px;" type="text" id="P_City" runat="server" required /><br /><br /><br />
							<input style="width:200px;" type="text" id="P_pin"  runat="server" pattern="[0-9]{6}" required /><br /><br />
						</td>
					</tr>
				</table>
			</td></tr>
			<tr><td class="blue-panel" style="padding-left:5px;">Communicarion Address:<br />
				<input type="checkbox" id="Address_Copy" style="padding-top:15px" onclick="return copy(this.from)"/>Check this box if Communication Address and Permanent Address are the same.
			</td></tr>
			<tr><td>
				<table style="padding-top:10px;">
					<tr>
						<td width=25%><br /><br />
							<label style="padding:10px;">Address</label><br /><br /><br /><br /><br />
							<label style="padding:10px;">City</label><br /><br />
							<label style="padding:10px;">Pin Code</label><br /><br /><br />
						</td>
						<td width=25% style="padding-top:0px;margin-top:0px;">
							<textarea name="address" style="width:200px" id="T_Address" runat="server"> </textarea><br /><br /><br />
							<input type="text" style="width:200px;" id="T_City" runat="server" /><br /><br />
							<input type="text" style="width:200px;" id="T_pin" runat="server" pattern="[0-9]{6}"/><br /><br />
						</td>
						<td width=25% style="padding-left:100px;">
							<label style="padding:10px;">Country</label><br /><br /><br />
							<label style="padding:10px;">State</label><br /><br />
						</td>
						<td>
							<input type="text" style="width:200px;" id="T_Country" runat="server" /><br /><br /><br /><br />
							<input type="text" style="width:200px;" id="T_State" runat="server" /><br /><br />
						</td>
					</tr>
				</table>
			</td></tr>
			<tr><td class="blue-panel" style="padding-left:5px;">Father's Details:</td></tr>
			<tr style="height:200px;"><td>
				<table>
					<tr>
						<td width=25% style="padding:20px;">
							<label style="padding:10px;">Name<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Qualification<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Office Address</label><br /><br /><br />
							<label style="padding:10px;">Telephone(Office)</label><br /><br /><br />
							<label style="padding:10px;" >Modernite<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;display:none;" id="Modernite_yearF">Modernite(Year)</label><br /><br /><br />
						</td>
						<td width=25%>
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="Father_Name" runat="server" required /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Qualification" id="Qualificationid" runat="server" required>
									<option value="" >  --Select Qualification--  </option>
									<option value="1">Graduation</option>
									<option value="2">Post Graduation</option>
									<option value="3">B.TECH M.SC</option>
									<option value="4">M.A. B.ED</option>
									<option value="5">DMLT, B.SC, MLT</option>
									<option value="6">BBA</option>
									<option value="7">MCA</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;" ><input style="width:200px;" type="text" id="AddressF" runat="server" /></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="Tf" runat="server" /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Modernite" id="ModerniteIdF" runat="server" required>
									<option value="" >  --Select Modernite(Father)--  </option>
									<option value="Yes">Yes</option>
									<option value="No">No</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;"><input style="display:none;" id="Modernite_YF" type="text" runat="server" /></span><br /><br /><br />
						</td>
						<td width=25% style="padding:20px;">
							<label style="padding:10px;">Mobile no<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Email Id<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Occupation<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Father Photo</label><br /><br /><br />
							<span style="display:none;" id="Modernite_BranchF"><label style="padding:10px;">Modernite(Branch)</label></span><br /><br /><br />
						</td>
						<td width=25%>
							<span style="padding-left:60px;"><input type="text" style="width:200px;" id="MF" runat="server" pattern="[0-9]{10}" required /></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="Fid" runat="server" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" required /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Occupation" id="Occupationid" runat="server" required>
									<option value="" >--Select Occupation--</option>
									<option value="1">Business</option>
									<option value="2">SERVICE</option>
									<option value="3">Others</option>
									<option value="4">HOUSEWIFE</option>
									<option value="5">LECTURER</option>
									<option value="6">TEACHER</option>
									<option value="7">DOCTOR</option>
								</select>
							</span><br /><br /><br />
							
							<span style="padding-left:60px;"><input style="width:200px;" type="file" runat="server" /></span><br /><br /><br />
							<span style="padding-left:60px;display:none;" id="Modernite_BF"><input style="width:200px;" type="text" id="MoBF" runat="server" /></span><br /><br /><br />
						</td>
					</tr>
				</table>
			</td></tr>
			<tr><td class="blue-panel" style="padding-left:5px;">Mother's Details:</td></tr>
			<tr style="height:200px;"><td>
				<table>
					<tr>
						<td width=25% style="padding:20px;">
							<label style="padding:10px;">Name<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Qualification<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Office Address</label><br /><br /><br />
							<label style="padding:10px;">Telephone(Office)</label><br /><br /><br />
							<label style="padding:10px;">Modernite<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;display:none;" id="Modernite_year">Modernite(Year)</label><br /><br /><br />
						</td>
						<td width=25%>
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="MN" runat="server" pattern="[a-z A-Z]+" required /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Qualificationf" id="Qualificationfid" runat="server" required>
									<option value="" >  --Select Qualification--  </option>
									<option value="1">Graduation</option>
									<option value="2">Post Graduation</option>
									<option value="3">B.TECH M.SC</option>
									<option value="4">M.A. B.ED</option>
									<option value="5">DMLT, B.SC, MLT</option>
									<option value="6">BBA</option>
									<option value="7">MCA</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;" ><input style="width:200px;" type="text" id="OffAdd" runat="server" /></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="TellMo" runat="server" /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="Modernite" id="ModerniteId" runat="server" required>
									<option value="" >  --Select Modernite(Mother)--  </option>
									<option value="Yes">Yes</option>
									<option value="No">No</option>
								</select>
							</span><br /><br /><br />
							<span style="padding-left:60px;"><input style="display:none;width:200px;" id="Modernite_Y" runat="server" type="text" /></span><br /><br /><br />
							
						</td>
						<td width=25% style="padding:20px;">
							<label style="padding:10px;">Mobile no<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Email Id<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Occupation<span style="color:red;">*</span></label><br /><br /><br />
							<label style="padding:10px;">Mother Photo</label><br /><br /><br />
							<span style="padding:10px;display:none;" id="Modernite_Branch"><label style="padding:10px;">Modernite(Branch)</label></span><br /><br /><br />
						
						</td>
						<td width=25%>
							<span style="padding-left:60px;"><input type="text" style="width:200px;" id="MobileM" runat="server" pattern="[0-9]{10}" required /></span><br /><br /><br />
							<span style="padding-left:60px;"><input style="width:200px;" type="text" id="Em" runat="server" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$" required /></span><br /><br /><br />
							<span style="padding-left:60px;">
								<select style="width:200px;" name="ccupationf" id="ccupationfid" runat="server" required>
									<option value="" >--Select Occupation--</option>
									<option value="1">Business</option>
									<option value="2">SERVICE</option>
									<option value="3">Others</option>
									<option value="4">HOUSEWIFE</option>
									<option value="5">LECTURER</option>
									<option value="6">TEACHER</option>
									<option value="7">DOCTOR</option>
								</select>
							</span><br /><br /><br />
							
							<span style="padding-left:60px;"><input style="width:200px;" type="file" runat="server"/></span><br /><br /><br />
							<span style="padding-left:60px;display:none;" id="Modernite_B"><input style="width:200px;" type="text" id="Modernite_Text" runat="server"/></span><br /><br /><br />
						</td>
					</tr>
				</table>
			</td></tr>
			<tr><td style="text-align:center;height:25px;">
				<input type="checkbox"id="AgreeId" onclick="return SubmitFunction(this.from)"/>I Agree<br /><br />
				<asp:Button CssClass="btt" ID="submitId" runat="server" Text="Submit" OnClick="submitId_Click"  /><br /><br />
                <asp:Button CssClass="btn" ID="Button1" runat="server" OnClick="Button1_Click" Text="Update"  />
                <br /><br />
				
			</td></tr>
		</table>
    </form>
</body>
</html>
