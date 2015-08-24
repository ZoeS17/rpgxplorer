<?xml version="1.0" encoding="UTF-8" ?>
<!-- Character sheet based on the Pahtfinder Society character sheet created by Paizo -->
<!-- Created by Nebular, nebular@shaw.ca -->
<!-- Version 1.9.5 (October 5, 2008) -->
<!-- For use with RPGXplorer 1.9.5 http://www.rpgxplorer.com/" -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:include href="config/config.xsl"/>
	<xsl:include href="config/rage.xsl"/>
	<xsl:include href="config/turning.xsl"/>
	<xsl:variable name="lcletters">abcdefghijklmnopqrstuvwxyz</xsl:variable>
	<xsl:variable name="ucletters">ABCDEFGHIJKLMNOPQRSTUVWXYZ</xsl:variable>
	<xsl:variable name="removeplus">+</xsl:variable>
	<xsl:variable name="replaceplus"> </xsl:variable>
	<xsl:variable name="removepercent">%</xsl:variable>
	<xsl:variable name="replacepercent"></xsl:variable>
	<xsl:variable name="removeft">ft.</xsl:variable>
	<xsl:variable name="replaceft"></xsl:variable>
	<xsl:variable name="removebab">+/</xsl:variable>
	<xsl:variable name="replacebab"></xsl:variable>
	
	<xsl:variable name="removeNewline">#10;</xsl:variable>
	<xsl:variable name="replaceNewline"><br /></xsl:variable>
	<xsl:template name="format-literal-content-helper">
		<xsl:param name="text"/>
		<xsl:variable name="linebreak" select="'&#10;'"/>
		<xsl:choose>
		<xsl:when test="contains($text,$linebreak)">
			<xsl:value-of select="substring-before($text,$linebreak)" disable-output-escaping="yes"/>
			<br/>
			<xsl:call-template name="format-literal-content-helper">
			<xsl:with-param name="text" select="substring-after($text,$linebreak)"/>
			</xsl:call-template>
		</xsl:when>
		<xsl:otherwise><xsl:value-of select="$text" disable-output-escaping="yes"/></xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	<xsl:template match="/CharacterXMLDataset/Character">
	<xsl:variable name="light" select="substring-before(substring-after(LightLoadInfo, 'to '), ' lb.')"/>
	<xsl:variable name="medium" select="substring-before(substring-after(MediumLoadInfo, 'to '), ' lb.')"/>
	<xsl:variable name="heavy" select="substring-before(substring-after(HeavyLoadInfo, 'to '), ' lb.')"/>
	
	<xsl:variable name="natbab" select="translate(substring(BAB1, 1, 3), $removebab, $replacebab)"/>
	
		<html>
			<head>
				<title><xsl:value-of select="CharacterName"/></title>
				<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
				<style>
					font {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: normal;
					}
					.headline {
						background-color: #000000;
						color: #FFFFFF;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 14px;
						font-weight: bold;
						text-transform: uppercase;
					}
					.tinytext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 6px;
						font-weight: normal;
						text-transform: uppercase;
						line-height: 6px;
						display: block;
					}
					.smalltext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 8px;
						font-weight: normal;
						text-transform: uppercase;
						display: block;
					}
					.mediumtext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 9px;
						font-weight: normal;
						text-transform: uppercase;
					}
					.headtext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 9px;
						font-weight: normal;
					}
					.normaltext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 9px;
						font-weight: normal;
						display: block;
					}
					.largetextnormal {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 12px;
						font-weight: normal;
						text-transform: uppercase;
					}
					.largetext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 12px;
						font-weight: bold;
						text-transform: uppercase;
					}
					.smallwritein {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 9px;
						font-weight: normal;
						text-transform: uppercase;
					}
					.largewritein {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 12px;
						font-weight: normal;
						text-transform: uppercase;
					}
					.box {
						border-right: #000000 1px solid;
						border-top: #000000 1px solid;
						border-left: #000000 1px solid;
						border-bottom: #000000 1px solid;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						background-color: #FFFFFF;
					}
					.boxgrey {
						border-right: #000000 1px solid;
						border-top: #000000 1px solid;
						border-left: #000000 1px solid;
						border-bottom: #000000 1px solid;
						font-family: bookman old style,times new roman,book antiqua,arial;
						background-color: #DDDDDD;
					}
					.boxwhite {
						border-right: #FFFFFF 1px solid;
						border-top: #FFFFFF 1px solid;
						border-left: #FFFFFF 1px solid;
						border-bottom: #FFFFFF 1px solid;
						background-color: #FFFFFF;
					}
					.writeinline {
						border-bottom: #000000 1px solid;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						display: block;
					}
					.writein {
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
					}
					.largewritten {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 14px;
						font-weight: normal;
					}
					.turningHeader {
						color: #FFFFFF;
						background-color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: bold;
					}
					.turningLine {
						color: #000000;
						background-color: #FFFFFF;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: normal;
					}
					.containerHeader {
						color: #FFFFFF;
						background-color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: bold;
					}
					.inventoryHeader {
						color: #000000;
						background-color: #DDDDDD;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: bold;
					}
					.spellListHeader {
						color: #000000;
						background-color: #DDDDDD;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: bold;
					}
					.spellListHeader2 {
						color: #FFFFFF;
						background-color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: bold;
					}
					.spellListHeaderPerDay {
						color: #000000;
						background-color: #FFFFFF;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 10px;
						font-weight: bold;
					}
					.spelltext {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 5pt;
						font-weight: normal;
					}
					.skillx {
						color: #000000;
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size: 9px;
						line-height: 9px;
						margin-top: 0px;
						margin-bottom: 0px;
						font-weight: normal;
					}
					A {
						color: #000000;
						text-decoration: none;
					}
					.cellRangeIncHeading {
						background-color:#666666;
						xborder-right:1px solid white;
					}
					.cellRangeIncHeadingText {
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size:6pt;
						font-weight:bold;
						color:#FFFFFF;
						text-align:center;
						text-transform:uppercase;
					}
					.cellRangeIncTop {
						background-color:#DDDDDD;
						border-right:1px solid white;
					}
					.cellRangeIncBottom {
						background-color:#DDDDDD;
						border-right:1px solid white;
						border-top:1px solid white;
					}
					.cellRangeIncText {
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size:6pt;
						text-align:center;
					}
					.cellRangeIncTextHvy {
						font-family: bookman old style,times new roman,book antiqua,arial;
						font-size:6pt;
						font-weight:bold;
						text-align:center;
					}
					.boxes {
						color: #000000;
						font-family: wingdings;
						font-size: 14px;
						font-weight: normal;
					}
					.v1 {
					FONT-SIZE: 1pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v2 {
					FONT-SIZE: 2pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v3 {
					FONT-SIZE: 3pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v4 {
					FONT-SIZE: 4pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v5 {
					FONT-SIZE: 5pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v6 {
					FONT-SIZE: 6pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v7 {
					FONT-SIZE: 7pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v8 {
					FONT-SIZE: 8pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v9 {
					FONT-SIZE: 9pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v10 {
					FONT-SIZE: 10pt; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v5w {
					FONT-SIZE: 5pt; COLOR: white; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v6w {
					FONT-SIZE: 6pt; COLOR: white; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v7w {
					FONT-SIZE: 7pt; COLOR: white; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v8w {
					FONT-SIZE: 8pt; COLOR: white; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v9w {
					FONT-SIZE: 9pt; COLOR: white; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
					.v10w {
					FONT-SIZE: 10pt; COLOR: white; FONT-FAMILY: bookman old style,times new roman,book antiqua,arial
					}
				</style>
			</head>
			<body>
				<!-- PAGE 1 -->
				<!-- Header -->
				<table width="100%" cellspacing="0" cellpadding="0">
					<tr>
						<td valign="top">
							<center>
							<img>
								<xsl:attribute name="src"><xsl:value-of select="$InstallPath"/>/xslt/images/Pathfinder/Society.jpg</xsl:attribute>
								<xsl:attribute name="style">margin-left: 10px; margin-right: 10px;</xsl:attribute>
							</img>
							</center>
						</td>
						<td width="100%">
							<table width="100%" cellspacing="0" cellpadding="0">
								<tr>
									<td>
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr>
												<td width="50%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="CharacterName"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="49%" class="writeinline" height="20" valign="bottom"><font class="headtext">&#160;</font><br/></td>
											</tr>
											<tr>
												<td><font class="smalltext">Character Name</font></td>
												<td><font class="smalltext">Character Number</font></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td>
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr>
												<td width="50%" class="writeinline" height="20" valign="bottom"><font class="headtext">&#160;</font></td>
												<td width="1%" rowspan="2"></td>
												<td width="11%" class="writeinline" height="20" valign="bottom"><font class="headtext">
													<xsl:choose>
														<xsl:when test="Alignment = 'Lawful Good'">
															LG
														</xsl:when>
														<xsl:when test="Alignment = 'Lawful Neutral'">
															LN
														</xsl:when>
														<xsl:when test="Alignment = 'Lawful Evil'">
															LE
														</xsl:when>
														<xsl:when test="Alignment = 'Neutral Good'">
															NG
														</xsl:when>
														<xsl:when test="Alignment = 'True Neutral'">
															N
														</xsl:when>
														<xsl:when test="Alignment = 'Neutral Evil'">
															NE
														</xsl:when>
														<xsl:when test="Alignment = 'Chaotic Good'">
															CG
														</xsl:when>
														<xsl:when test="Alignment = 'Chaotic Neutral'">
															CN
														</xsl:when>
														<xsl:when test="Alignment = 'Chaotic Evil'">
															CE
														</xsl:when>
													</xsl:choose>
													</font>
												</td>
												<td width="1%" rowspan="2"></td>
												<td width="44%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="PlayerName"/></font><br/></td>
											</tr>
											<tr>
												<td><font class="smalltext">Faction</font></td>
												<td><font class="smalltext">Alignment</font></td>
												<td><font class="smalltext">Player</font></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td>
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr>
												<td width="50%" class="writeinline" height="20" valign="bottom">
													<font class="headtext">
													<xsl:for-each select="Classes/Class">
														<a target="class"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ClassName"/></a><xsl:text> </xsl:text><xsl:value-of select="ClassLevel"/>
														<xsl:if test="position() != last()"> / </xsl:if>
													</xsl:for-each>
													</font>
												</td>
												<td width="1%" rowspan="2"></td>
												<td width="49%" class="writeinline" height="20" valign="bottom"><font class="headtext">&#160;</font></td>
											</tr>
											<tr>
												<td><font class="smalltext">Character Level</font></td>
												<td><font class="smalltext">Homeland</font></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td>
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr>
												<td width="14%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Race"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="11%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Deity"/></font><br/></td>
												<td width="1%" rowspan="2"></td>
												<td width="9%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Size"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="9%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Gender"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="9%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Age"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="9%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Height"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="11%" class="writeinline" height="20" valign="bottom"><font class="headtext"><xsl:value-of select="Weight"/></font></td>
												<td width="1%" rowspan="2"></td>
												<td width="9%" class="writeinline" height="20" valign="bottom">&#160;</td>
												<td width="1%" rowspan="2"></td>
												<td width="9%" class="writeinline" height="20" valign="bottom">&#160;</td>
											</tr>
											<tr>
												<td><font class="smalltext">Race</font></td>
												<td><font class="smalltext">Deity</font></td>
												<td><font class="smalltext">Size</font></td>
												<td><font class="smalltext">Gender</font></td>
												<td><font class="smalltext">Age</font></td>
												<td><font class="smalltext">Height</font></td>
												<td><font class="smalltext">Weight</font></td>
												<td><font class="smalltext">Hair</font></td>
												<td><font class="smalltext">Eyes</font></td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
				<!-- /Header -->
				
				<br/>
				
				<!-- Character Info -->
				<table width="100%" cellspacing="0" cellpadding="0">
					<tr>
						<td width="54%" valign="top">
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr>
									<td width="54%" valign="top">
										<table width="100%">
											<tbody>
												<tr>
													<td class="v4" align="middle" width="24%">
														ABILITY NAME
													</td>
													<td class="v4" align="middle" width="19%">
														ABILITY<br/>SCORE
													</td>
													<td class="v4" align="middle" width="19%">
														ABILITY<br/>MODIFIER
													</td>
													<td class="v4" align="middle" width="19%">
														BONUS OR<br/>PENALTY
													</td>
													<td class="v4" align="middle" width="19%" valign="bottom">
														MODIFIER
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>STR</b><br/><span class="v5w">STRENGTH</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="STR"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="STRMod"/></b><br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>DEX</b><br/><span class="v5w">DEXTERITY</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="DEX"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="DEXMod"/></b><br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>CON</b><br/><span class="v5w">CONSTITUTION</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="CON"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="CONMod"/></b><br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>INT</b><br/><span class="v5w">INTELLIGENCE</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="INT"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="INTMod"/></b><br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>WIS</b><br/><span class="v5w">WISDOM</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="WIS"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="WISMod"/></b><br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>CHA</b><br/><span class="v5w">CHARISMA</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="CHA"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="CHAMod"/></b><br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
													<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
														<br/>
													</td>
												</tr>
											</tbody>
										</table>
									</td>
									<td width="1%"></td>
									<td width="45%" valign="top">
										<table width="100%">
											<tbody>
												<tr>
													<td class="v4" align="middle" width="24%"></td>
													<td class="v4" align="middle" width="19%">
														TOTAL
													</td>
													<td class="v4" align="middle" width="19%">
														DR
													</td>
												</tr>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>HP</b><br/><span class="v5w">HIT POINTS</span>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="HP"/></b><br/>
													</td>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="DR"/></b><br/>
													</td>
												</tr>
											</tbody>
										</table>
										<table width="100%">
											<tbody>
												<tr>
													<td class="v4" align="left" width="100%">WOUNDS / CURRENT HP</td>
												</tr>
												<tr>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<br/><br/><br/>
													</td>
												</tr>
												<tr>
													<td class="v4" align="left" width="100%">NONLETHAL DAMAGE</td>
												</tr>
												<tr>
													<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<br/><br/>
													</td>
												</tr>
											</tbody>
										</table>
										<table width="100%">
											<tbody>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>INITIATIVE</b><br/><span class="v5w">MODIFIER</span>
													</td>
													<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="Initiative"/></b>
													</td>
													<td class="v7" align="middle">
														<b>=</b>
													</td>
													<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="translate(DEXMod, $removeplus, $replaceplus)"/></b>
													</td>
													<td class="v7" align="middle"><b>+</b></td>
													<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<b><xsl:value-of select="translate(Initiative, $removeplus, $replaceplus) - translate(DEXMod, $removeplus, $replaceplus)"/></b>
													</td>
												</tr>
												<tr>
													<td></td>
													<td class="v4" vAlign="top" align="middle">
														TOTAL
													</td>
													<td></td>
													<td class="v4" vAlign="top" align="middle">
														DEX<br/>MODIFIER
													</td>
													<td></td>
													<td class="v4" align="middle">
														MISC<br/>MODIFIER
													</td>
												</tr>
											</tbody>
										</table>
									</td>
								</tr>
							</table>
						
							<!-- Armor Class -->
							<table width="100%" border="0">
								<tbody>
									<tr>
										<td class="v9w" align="middle" bgColor="black">
											<b>AC</b><br/><span class="v5w">ARMOR CLASS</span>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="AC"/></b>
										</td>
										<td class="v7" align="middle"><b>=</b></td>
										<td class="v9" align="middle"><b>10</b></td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ArmorClass/ArmorBonus"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ArmorClass/ShieldBonus"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ArmorClass/DexBonus"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ArmorClass/SizeBonus"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ArmorClass/NaturalArmorBonus"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ArmorClass/DeflectionBonus"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="AC - 10 - ArmorClass/ArmorBonus - ArmorClass/ShieldBonus - ArmorClass/DexBonus - ArmorClass/SizeBonus - ArmorClass/NaturalArmorBonus - ArmorClass/DeflectionBonus"/></b>
										</td>
									</tr>
									<tr>
										<td></td>
										<td class="v4" vAlign="top" align="middle">
											TOTAL
										</td>
										<td></td>
										<td class="v4" vAlign="top" align="middle"></td>
										<td></td>
										<td class="v4" align="middle">
											ARMOR<br/>BONUS
										</td>
										<td></td>
										<td class="v4" align="middle">
											SHIELD<br/>BONUS
										</td>
										<td></td>
										<td class="v4" align="middle">
											DEX<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle">
											SIZE<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle">
											NATURAL<br/>ARMOR
										</td>
										<td></td>
										<td class="v4" align="middle">
											DEFLECTION<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle">
											MISC<br/>MODIFIER
										</td>
									</tr>
								</tbody>
							</table>
							<table width="100%" border="0">
								<tbody>
									<tr>
										<td class="v9w" align="middle" bgColor="black">
											<b>TOUCH</b><br/><span class="v5w">ARMOR CLASS</span>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ACTouch"/></b>
										</td>
										<td class="v9w" align="middle" bgColor="black">
											<b>FLAT-FOOTED</b><br/><span class="v5w">ARMOR CLASS</span>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="ACFlatfooted"/></b>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="right" width="45%" valign="top">
											<font class="v4">MODIFIERS</font>
										</td>
									</tr>
								</tbody>
							</table>
							<!-- /Armor Class -->
							
							<!-- Saving Throws -->
							<table cellPadding="0" width="100%" border="0">
								<tbody>
									<tr vAlign="bottom">
										<td class="v4" align="middle" width="20%">SAVING THROWS</td>
										<td class="v4" vAlign="bottom" align="middle" width="10%">
											TOTAL
										</td>
										<td></td>
										<td class="v4" align="middle" width="9%">
											BASE<br/>SAVE
										</td>
										<td></td>
										<td class="v4" align="middle" width="9%">
											ABILITY<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle" width="9%">
											MAGIC<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle" width="9%">
											MISC<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle" width="9%">
											TEMPORARY<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle" width="25%">
											MODIFIERS
										</td>
									</tr>
									<tr>
										<td class="v9w" align="middle" bgColor="black">
											<b>FORTITUDE</b><br/>
											<span class="v5w">(CONSTITUTION)</span>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="Fortitude"/></b>
										</td>
										<td class="v7" align="middle"><b>=</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Fortitude']/BaseSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Fortitude']/AbilityModifier"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Fortitude']/MagicSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Fortitude']/MiscSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
											&#160;
										</td>
										<td class="v7" vAlign="center" align="middle" rowSpan="3"><b>+</b></td>
										<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="left" valign="top" rowSpan="3" class="v7">
											<xsl:for-each select="CoreModifiers/CoreModifier[Valid = 'True' and Enabled = 'True' and SystemElement = 'Saving Throw' and Condition != '']">
												<xsl:sort select="Condition"/>
												<xsl:if test="ModifierValue &gt; 0">+</xsl:if><xsl:value-of select="ModifierValue"/><xsl:text> </xsl:text><xsl:value-of select="Condition"/><br/>
											</xsl:for-each>
											<xsl:if test="$hasrage = 1">
												+<xsl:value-of select="($baseragestr div 2)"/> to Will saves while in a rage
											</xsl:if>
											<br/>
										</td>
									</tr>
									<tr>
										<td class="v9w" align="middle" bgColor="black">
											<b>REFLEX</b><br/>
											<span class="v5w">(DEXTERITY)</span>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="Reflex"/></b>
										</td>
										<td class="v7" align="middle"><b>=</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Reflex']/BaseSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Reflex']/AbilityModifier"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Reflex']/MagicSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Reflex']/MiscSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
											&#160;
										</td>
									</tr>
									<tr>
										<td class="v9w" align="middle" bgColor="black">
											<b>WILL</b><br/>
											<span class="v5w">(WISDOM)</span>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="Will"/></b>
										</td>
										<td class="v7" align="middle"><b>=</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Will']/BaseSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Will']/AbilityModifier"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Will']/MagicSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SavingThrows/SavingThrow[Name = 'Will']/MiscSave"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td style="BORDER-RIGHT: #dddddd 3px solid; BORDER-TOP: #dddddd 3px solid; BORDER-LEFT: #dddddd 3px solid; BORDER-BOTTOM: #dddddd 3px solid" align="middle">
											&#160;
										</td>
									</tr>
								</tbody>
							</table>
							<!-- /Saving Throws-->
							
							<br/>
							
							<!-- Base Attack Bonus -->
							<table width="100%" border="0">
								<tbody>
									<tr>
										<td class="v9w" align="middle" bgColor="black">
											<b>BASE ATTACK BONUS</b><br/>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="BAB1"/></b>
										</td>
										<td class="v9w" align="middle" bgColor="black">
											<b>SPELL RESISTANCE</b><br/>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="SR"/></b>
										</td>
									</tr>
								</tbody>
							</table>
							<!-- /Base Attack Bonus -->
							
							<!-- Grapple -->
							<table width="100%">
								<tbody>
									<tr>
										<td class="v10w" align="middle" bgColor="black">
											<b>GRAPPLE</b><br/>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="Grapple"/></b>
										</td>
										<td class="v7" align="middle">
											<b>=</b>
										</td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="translate(BAB1, $removeplus, $replaceplus)"/></b>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b><xsl:value-of select="translate(STRMod, $removeplus, $replaceplus)"/></b><br/>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b>
											<xsl:choose>
												<xsl:when test="Size = 'Fine'">-16</xsl:when>
												<xsl:when test="Size = 'Diminutive'">-12</xsl:when>
												<xsl:when test="Size = 'Tiny'">-8</xsl:when>
												<xsl:when test="Size = 'Small'">-4</xsl:when>
												<xsl:when test="Size = 'Medium'">0</xsl:when>
												<xsl:when test="Size = 'Large'">4</xsl:when>
												<xsl:when test="Size = 'Huge'">8</xsl:when>
												<xsl:when test="Size = 'Gargantuan'">12</xsl:when>
												<xsl:when test="Size = 'Colossal'">16</xsl:when>
											</xsl:choose>
											</b><br/>
										</td>
										<td class="v7" align="middle"><b>+</b></td>
										<td class="v10" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
											<b>
											<xsl:choose>
												<xsl:when test="Size = 'Fine'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus)- -16"/></xsl:when>
												<xsl:when test="Size = 'Diminutive'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - -12"/></xsl:when>
												<xsl:when test="Size = 'Tiny'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - -8"/></xsl:when>
												<xsl:when test="Size = 'Small'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - -4"/></xsl:when>
												<xsl:when test="Size = 'Medium'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - 0"/></xsl:when>
												<xsl:when test="Size = 'Large'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - 4"/></xsl:when>
												<xsl:when test="Size = 'Huge'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - 8"/></xsl:when>
												<xsl:when test="Size = 'Gargantuan'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - 12"/></xsl:when>
												<xsl:when test="Size = 'Colossal'"><xsl:value-of select="translate(Grapple, $removeplus, $replaceplus) - translate(BAB1, $removeplus, $replaceplus) - translate(STRMod, $removeplus, $replaceplus) - 16"/></xsl:when>
											</xsl:choose>
											</b><br/>
										</td>
									</tr>
									<tr>
										<td></td>
										<td class="v4" vAlign="top" align="middle">
											TOTAL
										</td>
										<td></td>
										<td class="v4" vAlign="top" align="middle">
											BASE ATTACK<br/>BONUS
										</td>
										<td></td>
										<td class="v4" align="middle">
											STRENGTH<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle">
											SIZE<br/>MODIFIER
										</td>
										<td></td>
										<td class="v4" align="middle">
											MISC<br/>MODIFIER
										</td>
									</tr>
								</tbody>
							</table>
							<!-- /Grapple -->
							
							<!-- Attacks -->
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tbody>
									<tr>
										<td>
											<xsl:for-each select="Attacks/Attack">
												<table width="100%" cellspacing="0" cellpadding="0" border="0">
													<tr>
														<td height="10"></td>
													</tr>
												</table>
												<xsl:for-each select="Primary">
												<table width="100%" cellspacing="0" cellpadding="0" border="0">
													<tr>
														<td class="v8w" align="middle" bgColor="black" width="66%">
															<b>WEAPON</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="black" width="22%">
															<b>ATTACK BONUS</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="black" width="12%">
															<b>CRITICAL</b><br/>
														</td>
													</tr>
													<tr>
														<td valign="top" width="66%" style="BORDER: black 1px solid;" class="v7">
															<xsl:choose>
																<xsl:when test="FullName/text()[contains(., '+')]">
																	<xsl:choose>
																		<xsl:when test="BaseName/text()[contains(., '+')]">
																			<i><xsl:value-of select="BaseName"/></i>&#160;
																		</xsl:when>
																		<xsl:otherwise>
																			<i>+<xsl:value-of select="Enhancement"/>&#160;<xsl:value-of select="BaseName"/></i>&#160;
																		</xsl:otherwise>
																	</xsl:choose>
																</xsl:when>
																<xsl:otherwise>
																	<xsl:value-of select="BaseName"/>&#160;
																</xsl:otherwise>
															</xsl:choose>
															<xsl:if test="AttackNumber">
																x<xsl:value-of select="AttackNumber"/>
															</xsl:if>&#160;
														</td>
														<td valign="top" align="center" width="22%" style="BORDER: black 1px solid;" class="v7">
															<xsl:value-of select="Attacks"/>&#160;
														</td>
														<td valign="top" align="center" width="12%" style="BORDER: black 1px solid;" class="v7">
															<xsl:if test="CriticalMultiplier">
																<xsl:if test="CriticalRange != '20-20'"><xsl:value-of select="CriticalRange"/>/</xsl:if>x<xsl:value-of select="CriticalMultiplier"/>
															</xsl:if>&#160;
														</td>
													</tr>
												</table>
												<table width="100%" cellspacing="0" cellpadding="0" border="0">
													<tr>
														<td class="v6w" align="middle" bgColor="black" width="15%">
															<b>TYPE</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="black" width="15%">
															<b>RANGE</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="black" width="36%">
															<b>AMMUNITION</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="black" width="34%">
															<b>DAMAGE</b><br/>
														</td>
													</tr>
													<tr>
														<td valign="top" align="center" width="15%" style="BORDER: black 1px solid;" class="v7">
															<xsl:choose>
																<xsl:when test="BaseDamageType = 'Bludgeoning'">B</xsl:when>
																<xsl:when test="BaseDamageType = 'Piercing'">P</xsl:when>
																<xsl:when test="BaseDamageType = 'Slashing'">S</xsl:when>
																<xsl:otherwise>
																	<xsl:choose>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'Or') and contains(BaseDamageType, 'Piercing')">B/P</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Slashing') and contains(BaseDamageType, 'Or') and contains(BaseDamageType, 'Piercing')">P/S</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'Or') and contains(BaseDamageType, 'Slashing')">B/S</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'And') and contains(BaseDamageType, 'Piercing')">B+P</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Slashing') and contains(BaseDamageType, 'And') and contains(BaseDamageType, 'Piercing')">P+S</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'And') and contains(BaseDamageType, 'Slashing')">B+S</xsl:when>
																	</xsl:choose>
																</xsl:otherwise>
															</xsl:choose>&#160;
														</td>
														<td valign="top" align="center" width="15%" style="BORDER: black 1px solid;" class="v7">
															<xsl:value-of select="Range"/>&#160;
														</td>
														<td valign="top" align="center" width="36%" style="BORDER: black 1px solid;" class="v7">
															&#160;
														</td>
														<td valign="top" align="center" width="34%" style="BORDER: black 1px solid;" class="v7">
															<xsl:value-of select="BaseDamage"/>
															<xsl:for-each select="PrimaryExtraDamage/DamageName">
																<xsl:value-of select="."/>
															</xsl:for-each>&#160;
														</td>
													</tr>
												</table>
												</xsl:for-each>
												<xsl:for-each select="Secondary">
												<table width="100%" cellspacing="0" cellpadding="0" border="0">
													<tr>
														<td class="v8w" align="middle" bgColor="#666666" width="66%">
															<b>WEAPON</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="#666666" width="22%">
															<b>ATTACK BONUS</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="#666666" width="12%">
															<b>CRITICAL</b><br/>
														</td>
													</tr>
													<tr>
														<td valign="top" width="66%" style="BORDER: #666666 1px solid;" class="v7">
															<xsl:choose>
																<xsl:when test="FullName/text()[contains(., '+')]">
																	<xsl:choose>
																		<xsl:when test="BaseName/text()[contains(., '+')]">
																			<i><xsl:value-of select="BaseName"/></i>&#160;
																		</xsl:when>
																		<xsl:otherwise>
																			<i>+<xsl:value-of select="Enhancement"/>&#160;<xsl:value-of select="BaseName"/></i>&#160;
																		</xsl:otherwise>
																	</xsl:choose>
																</xsl:when>
																<xsl:otherwise>
																	<xsl:value-of select="BaseName"/>&#160;
																</xsl:otherwise>
															</xsl:choose>
															<xsl:if test="AttackNumber">
																x<xsl:value-of select="AttackNumber"/>
															</xsl:if>&#160;
														</td>
														<td valign="top" align="center" width="22%" style="BORDER: #666666 1px solid;" class="v7">
															<xsl:value-of select="Attacks"/>&#160;
														</td>
														<td valign="top" align="center" width="12%" style="BORDER: #666666 1px solid;" class="v7">
															<xsl:if test="CriticalMultiplier">
																<xsl:if test="CriticalRange != '20-20'"><xsl:value-of select="CriticalRange"/>/</xsl:if>x<xsl:value-of select="CriticalMultiplier"/>
															</xsl:if>&#160;
														</td>
													</tr>
												</table>
												<table width="100%" cellspacing="0" cellpadding="0" border="0">
													<tr>
														<td class="v6w" align="middle" bgColor="#666666" width="15%">
															<b>TYPE</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="#666666" width="15%">
															<b>RANGE</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="#666666" width="36%">
															<b>AMMUNITION</b><br/>
														</td>
														<td class="v6w" align="middle" bgColor="#666666" width="34%">
															<b>DAMAGE</b><br/>
														</td>
													</tr>
													<tr>
														<td valign="top" align="center" width="15%" style="BORDER: #666666 1px solid;" class="v7">
															<xsl:choose>
																<xsl:when test="BaseDamageType = 'Bludgeoning'">B</xsl:when>
																<xsl:when test="BaseDamageType = 'Piercing'">P</xsl:when>
																<xsl:when test="BaseDamageType = 'Slashing'">S</xsl:when>
																<xsl:otherwise>
																	<xsl:choose>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'Or') and contains(BaseDamageType, 'Piercing')">B/P</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Slashing') and contains(BaseDamageType, 'Or') and contains(BaseDamageType, 'Piercing')">P/S</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'Or') and contains(BaseDamageType, 'Slashing')">B/S</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'And') and contains(BaseDamageType, 'Piercing')">B+P</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Slashing') and contains(BaseDamageType, 'And') and contains(BaseDamageType, 'Piercing')">P+S</xsl:when>
																		<xsl:when test="contains(BaseDamageType, 'Bludgeoning') and contains(BaseDamageType, 'And') and contains(BaseDamageType, 'Slashing')">B+S</xsl:when>
																	</xsl:choose>
																</xsl:otherwise>
															</xsl:choose>&#160;
														</td>
														<td valign="top" align="center" width="15%" style="BORDER: #666666 1px solid;" class="v7">
															<xsl:value-of select="Range"/>&#160;
														</td>
														<td valign="top" align="center" width="36%" style="BORDER: #666666 1px solid;" class="v7">
															&#160;
														</td>
														<td valign="top" align="center" width="34%" style="BORDER: #666666 1px solid;" class="v7">
															<xsl:value-of select="BaseDamage"/>
															<xsl:for-each select="SecondaryExtraDamage/DamageName">
																<xsl:value-of select="."/>
															</xsl:for-each>&#160;
														</td>
													</tr>
												</table>
												</xsl:for-each>
											</xsl:for-each>
										</td>
									</tr>
								</tbody>
							</table>
							<!-- /Attacks -->
							
						</td>
						<td width="1%">
						</td>
						<td width="45%" valign="top">
							<!-- Speed -->
							<table width="100%" cellspacing="0" cellpadding="0">
								<tr>
									<td width="81%" valign="middle">
										<table width="100%">
											<tbody>
												<tr>
													<td class="v10w" align="middle" bgColor="black">
														<b>SPEED</b><br/><span class="v5w">LAND</span>
													</td>
													<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<table width="100%" cellspacing="0" cellpadding="0" border="0">
															<tr>
																<td class="v9" width="50%" align="center"><b><xsl:value-of select="BaseSpeed"/></b></td>
																<td class="v9" width="50%" align="center">
																	<b><xsl:variable name="speed" select="BaseSpeed"/><xsl:text> </xsl:text>
																	<xsl:value-of select="substring-before($speed, ' ') div 5"/> Sq.</b>
																</td>
															</tr>
														</table>
													</td>
													<td class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<table width="100%" cellspacing="0" cellpadding="0" border="0">
															<tr>
																<td class="v9" width="50%" align="center"><b><xsl:value-of select="Speed"/></b></td>
																<td class="v9" width="50%" align="center">
																	<b><xsl:variable name="speed" select="Speed"/><xsl:text> </xsl:text>
																	<xsl:value-of select="substring-before($speed, ' ') div 5"/> Sq.</b>
																</td>
															</tr>
														</table>
													</td>
												</tr>
												<tr>
													<td></td>
													<td class="v4" vAlign="top" align="middle">
														BASE SPEED
													</td>
													<td class="v4" vAlign="top" align="middle">
														WITH ARMOR
													</td>
												</tr>
											</tbody>
										</table>
										<table width="100%">
											<tbody>
												<tr>
													<td width="30%" class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<xsl:if test="Fly">
														<b><xsl:value-of select="Fly"/></b>
														</xsl:if>
														<br/>
													</td>
													<td width="23%" class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<xsl:if test="Swim">
														<b><xsl:value-of select="Swim"/></b>
														</xsl:if>
														<br/>
													</td>
													<td width="23%" class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<xsl:if test="Climb">
														<b><xsl:value-of select="Climb"/></b>
														</xsl:if>
														<br/>
													</td>
													<td width="23%" class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="middle">
														<xsl:if test="Burrow">
														<b><xsl:value-of select="Burrow"/></b>
														</xsl:if>
														<br/>
													</td>
												</tr>
												<tr>
													<td class="v4" vAlign="top" align="middle">
														FLY
													</td>
													<td class="v4" vAlign="top" align="middle">
														SWIM
													</td>
													<td class="v4" vAlign="top" align="middle">
														CLIMB
													</td>
													<td class="v4" vAlign="top" align="middle">
														BURROW
													</td>
												</tr>
											</tbody>
										</table>
									</td>
									<td width="1%"></td>
									<td width="18%" class="v9" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid" align="right" valign="top">
										<font class="v4">TEMP MODIFIERS</font><br/>
									</td>
								</tr>
							</table>
							<!-- /Speed -->
							
							<br/>
							
							<!-- Skills -->
							<table width="100%" cellspacing="0" cellpadding="0">
								<tr>
									<td>
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr class="headline">
												<td height="22" align="center">
													Skills
												</td>
											</tr>
											<tr>
												<td height="5"></td>
											</tr>
										</table>
									</td>
								</tr>
								<tr>
									<td>
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr>
												<td align="center"><font class="smalltext"><br/></font></td>
												<td align="left"><font class="smalltext">Skill Names</font></td>
												<td align="center"><font class="smalltext">Key<br/>Ability</font></td>
												<td align="center"><font class="smalltext">Skill<br/>Mod.</font></td>
												<td align="center"></td>
												<td align="center"><font class="smalltext">Ability<br/>Mod.</font></td>
												<td align="center"></td>
												<td align="center" valign="bottom"><font class="smalltext">Ranks</font></td>
												<td align="center"></td>
												<td align="center"><font class="smalltext">Misc.<br/>Mod.</font></td>
											</tr>
											<!-- Skill -->
											<xsl:for-each select="Skills/Skill[TrainedOnly = 'False' or SkillRanks &gt; 0]">
												<xsl:sort select="SkillName"/>
												<tr>
													<td align="center">
														<table width="15" height="15" border="0" class="box" cellspacing="0" cellpadding="0"><tr><td valign="bottom" align="center" class="skillx"><xsl:if test="ClassSkill = 'Yes'">X</xsl:if></td></tr></table>
													</td>
													<td align="left" class="writein">
														<a target="skill"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SkillName"/></a><xsl:if test="CheckMultiplier = '1'"><b>*</b></xsl:if><xsl:if test="TrainedOnly = 'False'"><sup><font style="font-family: wingdings; font-size: 10px">u</font></sup></xsl:if>
													</td>
													<td align="center" class="writein">
														<xsl:value-of select="Ability"/>
													</td>
													<td align="center" class="writeinline">
														<xsl:if test="Final != 'X'"><xsl:value-of select="translate(Final, $removeplus, $replaceplus)"/></xsl:if><br/>
													</td>
													<td align="center"><font class="smalltext">=</font></td>
													<td align="center" class="writeinline">
														<xsl:choose>
															<xsl:when test="Ability = 'STR'"><xsl:value-of select="translate(../../STRMod, $removeplus, $replaceplus)"/></xsl:when>
															<xsl:when test="Ability = 'DEX'"><xsl:value-of select="translate(../../DEXMod, $removeplus, $replaceplus)"/></xsl:when>
															<xsl:when test="Ability = 'CON'"><xsl:value-of select="translate(../../CONMod, $removeplus, $replaceplus)"/></xsl:when>
															<xsl:when test="Ability = 'INT'"><xsl:value-of select="translate(../../INTMod, $removeplus, $replaceplus)"/></xsl:when>
															<xsl:when test="Ability = 'WIS'"><xsl:value-of select="translate(../../WISMod, $removeplus, $replaceplus)"/></xsl:when>
															<xsl:when test="Ability = 'CHA'"><xsl:value-of select="translate(../../CHAMod, $removeplus, $replaceplus)"/></xsl:when>
														</xsl:choose><br/>
													</td>
													<td align="center"><font class="smalltext">+</font></td>
													<td align="center" class="writeinline">
														<xsl:if test="SkillRanks > 0"><xsl:value-of select="SkillRanks"/></xsl:if><br/>
													</td>
													<td align="center"><font class="smalltext">+</font></td>
													<td align="center" class="writeinline">
														<xsl:choose>
															<xsl:when test="Ability = 'STR'">
																<xsl:value-of select="Modifier - translate(../../STRMod, $removeplus, $replaceplus)"/>
															</xsl:when>
															<xsl:when test="Ability = 'DEX'">
																<xsl:value-of select="Modifier - translate(../../DEXMod, $removeplus, $replaceplus)"/>
															</xsl:when>
															<xsl:when test="Ability = 'CON'">
																<xsl:value-of select="Modifier - translate(../../CONMod, $removeplus, $replaceplus)"/>
															</xsl:when>
															<xsl:when test="Ability = 'INT'">
																<xsl:value-of select="Modifier - translate(../../INTMod, $removeplus, $replaceplus)"/>
															</xsl:when>
															<xsl:when test="Ability = 'WIS'">
																<xsl:value-of select="Modifier - translate(../../WISMod, $removeplus, $replaceplus)"/>
															</xsl:when>
															<xsl:when test="Ability = 'CHA'">
																<xsl:value-of select="Modifier - translate(../../CHAMod, $removeplus, $replaceplus)"/>
															</xsl:when>
														</xsl:choose><br/>
													</td>
												</tr>
											</xsl:for-each>
											<!-- /Skill -->
										</table>
									</td>
								</tr>
								<tr>
									<td width="100%">
										<table cellspacing="0" cellpadding="0">
											<tr>
												<td colspan="2" height="5"></td>
											</tr>
											<tr>
												<td align="center"><font style="font-family: wingdings; font-size: 10px;display: block;">u</font></td>
												<td><font class="smalltext"> Denotes a skill that can be used untrained</font></td>
											</tr>
											<tr>
												<td colspan="2" height="5"></td>
											</tr>
											<tr>
												<td align="center"><font class="smalltext">*</font></td>
												<td><font class="smalltext"> Armor check penaly, if any, applies</font></td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
							<!-- /Skills -->
						</td>
					</tr>
				</table>
				<!-- /PAGE 1 -->
				<br style="page-break-after: always"/>
				
				<!-- PAGE 2 -->
				
				<xsl:if test="SpellLikeAbilities/SpellLikeAbility">
					<table cellSpacing="0" cellPadding="2" width="100%" border="0">
						<tbody>
							<tr class="spellListHeader">
								<td class="v8w" align="middle" bgColor="black">SPELL-LIKE ABILITIES
									<span class="v6w">NAME</span>
								</td>
								<td class="v6w" width="9%" align="center" bgColor="black">CASTER LEVEL</td>
								<td class="v6w" width="11%" align="center" bgColor="black">USAGE</td>
								<td class="v6w" width="6%" align="center" bgColor="black">DC</td>
								<td class="v6w" width="6%" align="center" bgColor="black">SR</td>
								<td class="v6w" width="10%" align="center" bgColor="black">CASTING</td>
								<td class="v6w" width="10%" align="center" bgColor="black">RANGE</td>
								<td class="v6w" width="12%" align="center" bgColor="black">DURATION</td>
								<td class="v6w" width="9%" align="center" bgColor="black">SAVE</td>
								<td class="v6w" width="12%" align="center" bgColor="black">SOURCE</td>
							</tr>
							<xsl:for-each select="SpellLikeAbilities/SpellLikeAbility">
							<tr>
			                    <xsl:if test="position() mod 2 = 0">
			                      <xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
			                    </xsl:if>
								<td align="" style="border-bottom: 1px solid black; width=14%" class="v7">
									<a target="spell">
										<xsl:attribute name="href">
											<xsl:value-of select="AbilitySpell/HelpPage"/>
										</xsl:attribute>
										<xsl:value-of select="SpellName"/>
									</a>
								</td>
								<td align="center" style="border-bottom: 1px solid black; width=9%" class="v7"><xsl:value-of select="CasterLevel"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=11%" class="v7"><xsl:value-of select="Usage"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=6%" class="v7"><xsl:value-of select="DC"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=6%" class="v7"><xsl:value-of select="AbilitySpell/SpellResistance"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=10%" class="v7"><xsl:value-of select="AbilitySpell/Time"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=10%" class="v7"><xsl:value-of select="AbilitySpell/Range"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=12%" class="v7"><xsl:value-of select="AbilitySpell/Duration"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=9%" class="v7"><xsl:value-of select="AbilitySpell/SavingThrow"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=12%" class="v7"><xsl:value-of select="AbilitySpell/Sourcebook"/></td>
							</tr>
							</xsl:for-each>
						</tbody>
					</table>
					<br/>
				</xsl:if>
				
				<xsl:if test="PsiLikeAbilities/PsiLikeAbility">
					<table cellSpacing="0" cellPadding="2" width="100%" border="0">
						<tbody>
							<tr class="spellListHeader">
								<td class="v8w" align="middle" bgColor="black">PSI-LIKE ABILITIES
									<span class="v6w">NAME</span>
								</td>
								<td class="v6w" width="9%" align="center" bgColor="black">MANIFESTER LEVEL</td>
								<td class="v6w" width="11%" align="center" bgColor="black">USAGE</td>
								<td class="v6w" width="6%" align="center" bgColor="black">DC</td>
								<td class="v6w" width="6%" align="center" bgColor="black">SR</td>
								<td class="v6w" width="10%" align="center" bgColor="black">MANIFESTING</td>
								<td class="v6w" width="10%" align="center" bgColor="black">RANGE</td>
								<td class="v6w" width="12%" align="center" bgColor="black">DURATION</td>
								<td class="v6w" width="9%" align="center" bgColor="black">SAVE</td>
								<td class="v6w" width="12%" align="center" bgColor="black">SOURCE</td>
							</tr>
							<xsl:for-each select="PsiLikeAbilities/PsiLikeAbility">
							<tr class="spelltext">
			                    <xsl:if test="position() mod 2 = 0">
			                      <xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
			                    </xsl:if>
								<td align="" style="border-bottom: 1px solid black; width=14%">
									<a target="spell">
										<xsl:attribute name="href">
											<xsl:value-of select="AbilityPower/HelpPage"/>
										</xsl:attribute>
										<xsl:value-of select="PowerName"/>
									</a>
								</td>
								<td align="center" style="border-bottom: 1px solid black; width=9%"><xsl:value-of select="ManifesterLevel"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=11%"><xsl:value-of select="Usage"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=6%"><xsl:value-of select="DC"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=6%"><xsl:value-of select="AbilityPower/PowerResistance"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=10%"><xsl:value-of select="AbilityPower/Time"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=10%"><xsl:value-of select="AbilityPower/Range"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=12%"><xsl:value-of select="AbilityPower/Duration"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=9%"><xsl:value-of select="AbilityPower/SavingThrow"/></td>
								<td align="center" style="border-bottom: 1px solid black; width=12%"><xsl:value-of select="AbilityPower/Sourcebook"/></td>
							</tr>
							</xsl:for-each>
						</tbody>
					</table>
					<br/>
				</xsl:if>
				
				<!-- Armor Class Gear -->
				<table width="100%" cellspacing="0" cellpadding="0" border="0">
					<tr>
						<td valign="top">
							<table border="0" cellpadding="0" cellspacing="0" width="100%">
								<tr>
									<td class="v8w" align="middle" bgColor="black">
										<b>ARMOR CLASS GEAR</b><br/>
									</td>
									<td class="v6w" align="middle" bgColor="black">
										<b>BONUS</b><br/>
									</td>
									<td class="v6w" align="middle" bgColor="black">
										<b>TYPE</b><br/>
									</td>
									<td class="v6w" align="middle" bgColor="black">
										<b>CHECK PENALTY</b><br/>
									</td>
									<td class="v6w" align="middle" bgColor="black">
										<b>SPELL FAILURE</b><br/>
									</td>
									<td class="v6w" align="middle" bgColor="black">
										<b>WEIGHT</b><br/>
									</td>
									<td class="v6w" align="middle" bgColor="black">
										<b>PROPERTIES</b><br/>
									</td>
								</tr>
								<xsl:for-each select="DefenseModifiers/DefenseModifier[Enabled = 'True' and Valid = 'True']">
									<tr>
										<td align="left" style="border: 1px solid black;" class="v7">
											<xsl:value-of select="Source"/><br/>
										</td>
										<td align="center" style="border: 1px solid black;" class="v7">
											<p class="itemDetail"><xsl:value-of select="ModifierValue"/><br/></p>
										</td>
										<td align="left" style="border: 1px solid black;" class="v7">
											<p class="itemDetail"><xsl:value-of select="ModifierType"/><br/></p>
										</td>
										<td align="left" style="border: 1px solid black;" class="v7"><br/></td>
										<td align="left" style="border: 1px solid black;" class="v7"><br/></td>
										<td align="left" style="border: 1px solid black;" class="v7"><br/></td>
										<td align="left" style="border: 1px solid black;" class="v7"><br/></td>
									</tr>
								</xsl:for-each>
							</table>
						</td>
					</tr>
				</table>
				<!-- /Armor Class Gear -->
				
				<br/>
				
				<table width="100%" cellspacing="0" cellpadding="0" border="0">
					<tr>
						<td width="33%" valign="top" height="100%">
							<table width="100%" cellspacing="0" cellpadding="0" border="0" height="100%">
								<tr>
									<td>
										<!-- Gear -->
										<table width="100%" cellspacing="0" cellpadding="0" border="0">
											<tr>
												<td class="v8w" align="middle" bgColor="black" colspan="2">
													<b>GEAR</b><br/>
												</td>
											</tr>
											<tr>
												<td align="center" style="border: 1px solid black;" class="v7" width="80%"><b>ITEM</b><br/></td>
												<td align="center" style="border: 1px solid black;" class="v7" width="19%"><b>WT.</b><br/></td>
											</tr>
											<xsl:for-each select="/CharacterXMLDataset/Character/Inventory/InventoryItem">
												<xsl:sort select="ItemName"/>
												<tr>
													<td align="left" style="border: 1px solid black;" class="v7" width="80%">
														<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ItemName"/></a>
														<xsl:if test="Charges"><xsl:text> </xsl:text>(<xsl:value-of select="Charges"/> charges)</xsl:if>
														<xsl:if test="Quantity &gt; 1"><xsl:text> </xsl:text>x<xsl:value-of select="Quantity"/></xsl:if>
													</td>
													<td align="center" style="border: 1px solid black;" class="v7" width="19%">
														<xsl:choose><xsl:when test="ItemWeight != ''"><xsl:value-of select="ItemWeight"/></xsl:when><xsl:otherwise>0 lb.</xsl:otherwise></xsl:choose>
													</td>
												</tr>
											</xsl:for-each>
											<xsl:call-template name="emptyinventory"><xsl:with-param name="count" select="$BlankInventoryLines"/></xsl:call-template>
											<tr>
												<td class="v8w" align="middle" bgColor="black">
													<b>TOTAL WEIGHT</b><br/>
												</td>
												<td align="center" style="border: 1px solid black;" class="v7" width="83%">
													<xsl:value-of select="InventoryWeight"/>
												</td>
											</tr>
										</table>
										<!-- /Gear -->
									</td>
								</tr>
							
								<tr>
									<td>
										<!-- Carrying Capacity -->
										<table width="100%" cellspacing="0" cellpadding="0" border="0">
											<tr>
												<td colspan="7" height="10"></td>
											</tr>
											<tr>
												<td class="v8" align="middle" width="24%">
													<b>LIGHT<br/>LOAD</b>
												</td>
												<td width="1%"></td>
												<td class="v8" style="BORDER: black 1px solid;" align="middle" width="24%">
													<xsl:value-of select="$light"/> lb.
												</td>
												<td width="1%"></td>
												<td class="v8" align="middle" width="24%">
													<b>LIFT OVER<br/>HEAD</b>
												</td>
												<td width="1%"></td>
												<td class="v8" style="BORDER: black 1px solid;" align="middle" width="24%">
													<xsl:value-of select="$heavy"/> lb.
												</td>
											</tr>
											<tr>
												<td colspan="7" height="5"></td>
											</tr>
											<tr>
												<td class="v8" align="middle" width="24%">
													<b>MEDIUM<br/>LOAD</b>
												</td>
												<td width="1%"></td>
												<td class="v8" style="BORDER: black 1px solid;" align="middle" width="24%">
													<xsl:value-of select="$medium"/> lb.
												</td>
												<td width="1%"></td>
												<td class="v8" align="middle" width="24%">
													<b>LIFT OFF<br/>GROUND</b>
												</td>
												<td width="1%"></td>
												<td class="v8" style="BORDER: black 1px solid;" align="middle" width="24%">
													<xsl:value-of select="$heavy * 2"/> lb.
												</td>
											</tr>
											<tr>
												<td colspan="7" height="5"></td>
											</tr>
											<tr>
												<td class="v8" align="middle" width="24%">
													<b>HEAVY<br/>LOAD</b>
												</td>
												<td width="1%"></td>
												<td class="v8" style="BORDER: black 1px solid;" align="middle" width="24%">
													<xsl:value-of select="$heavy"/> lb.
												</td>
												<td width="1%"></td>
												<td class="v8" align="middle" width="24%">
													<b>DRAG OR<br/>PUSH</b>
												</td>
												<td width="1%"></td>
												<td class="v8" style="BORDER: black 1px solid;" align="middle" width="24%">
													<xsl:value-of select="$heavy * 5"/> lb.
												</td>
											</tr>
											<tr>
												<td colspan="7" height="5"></td>
											</tr>
										</table>
										<!-- /Carrying Capacity -->
									</td>
								</tr>
							
								<tr>
									<td height="100%">
										<!-- Money -->
										<table width="100%" cellspacing="0" cellpadding="0" border="0" style="border: 1px solid black" height="100%">
											<tr>
												<td class="v8w" align="middle" bgColor="black" colspan="2">
													<b>MONEY</b><br/>
												</td>
											</tr>
											<tr>
												<td class="v8" valign="top" height="100%">
													<xsl:value-of select="Money"/><br/><br/><br/><br/>
												</td>
											</tr>
										</table>
										<!-- /Money -->
									</td>
								</tr>
							</table>
						</td>
						<td width="1%"></td>
						<td width="65%" valign="top" height="100%">
							<table width="100%" cellspacing="0" cellpadding="0" border="0" height="100%">
								<tr>
									<td>
										<!-- Feats -->
										<table width="100%" cellspacing="0" cellpadding="0" border="0">
											<tr>
												<td class="v8w" align="middle" bgColor="black" colspan="2">
													<b>FEATS</b><br/>
												</td>
											</tr>
											<xsl:for-each select="Feats/Feat[Disabled != 'True']">
												<xsl:sort select="FeatName"/>
												<tr>
													<td class="v8" valign="top" style="border-bottom: 1px solid black">
														<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatName"/></a>
														<xsl:text> </xsl:text><xsl:value-of select="FocusName"/>
													</td>
												</tr>
											</xsl:for-each>
										</table>
										<!-- /Feats -->
									</td>
								</tr>
								<tr>
									<td>
										<br/>
									</td>
								</tr>
								<tr>
									<td>
										<!-- Special Abilities -->
										<table width="100%" cellspacing="0" cellpadding="0" border="0">
											<tr>
												<td class="v8w" align="middle" bgColor="black" colspan="2">
													<b>SPECIAL ABILITIES</b><br/>
												</td>
											</tr>
											<xsl:for-each select="Features/Feature">
												<xsl:sort select="FeatureName"/>
												<xsl:if test="not(Disabled = 'True')">
												<tr>
													<td class="v8" valign="top" style="border-bottom: 1px solid black">
														<a target="feat"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="FeatureName"/></a>
													</td>
												</tr>
												</xsl:if>
											</xsl:for-each>
										</table>
										<!-- /Special Abilities -->
									</td>
								</tr>
								<tr>
									<td>
										<br/>
									</td>
								</tr>
								<tr>
									<td>
										<!-- Languages -->
										<table width="100%" cellspacing="0" cellpadding="0">
											<tr>
												<td class="v8w" align="middle" bgColor="black" colspan="2">
													<b>LANGUAGES</b><br/>
												</td>
											</tr>
											<xsl:for-each select="Languages/Language">
												<tr>
													<td class="v8" valign="top" style="border-bottom: 1px solid black">
														<xsl:value-of select="LanguageName"/>
													</td>
												</tr>
											</xsl:for-each>
										</table>
										<!-- /Languages -->
									</td>
								</tr>
								<tr>
									<td>
										<br/>
									</td>
								</tr>
								<tr>
									<td height="100%">
										<!-- Experience Points -->
										<table width="100%" cellspacing="0" cellpadding="0" border="0" height="100%">
											<tr>
												<td class="v8w" align="middle" bgColor="black">
													<b>EXPERIENCE POINTS</b><br/>
												</td>
												<td class="v8w" align="middle" bgcolor="black">
													<b>PRESTIGE AWARD</b><br/>
												</td>
											</tr>
											<tr>
												<td class="v7" style="border: 1px solid black" valign="top" align="left" height="100%">
													&#160;<xsl:value-of select="XP"/><br/><br/><br/><br/>
												</td>
												<td class="v8" style="border: 1px solid black" align="center" valign="top" height="100%">
													&#160;
												</td>
											</tr>
										</table>
										<!-- /Experience Points -->
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
				
				<!-- /PAGE2 -->
				
				<br style="page-break-after: always"/>
				<xsl:for-each select="Spells/ClassSpells[not(ClassName = preceding-sibling::ClassSpells/ClassName)]">
					<!-- Caster Class -->
					<xsl:variable name="class" select="ClassName"/>					
					<table width="100%" cellspacing="0" cellpadding="0">
						<tr>
							<td width="50%" rowspan="4" valign="top">
								<table width="100%" cellspacing="0" cellpadding="0">
									<!-- Spells -->
									<tr>
										<td>
											<table width="100%" cellspacing="0" cellpadding="0">
												<tr class="headline">
													<td height="22" align="center">
														<xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> Spells
														<xsl:choose>
															<xsl:when test="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/MemorizedSpells and $UseSpellsPrepared = 'Yes'">
																PREPARED
															</xsl:when>
															<xsl:otherwise>
																KNOWN
															</xsl:otherwise>
														</xsl:choose>
													</td>
												</tr>
												<tr>
													<td height="5"></td>
												</tr>
											</table>
										</td>
									</tr>
									<xsl:if test="../../Domains/Domain/ClassName/text() = $class">
										<tr>
											<td class="largetext" align="left"><b>DOMAINS</b>
												<table width="100%">
													<xsl:for-each select="../../Domains/Domain">
														<xsl:variable name="domain" select="DomainName"/>
														<tr>
															<td class="writeinline">
																<a target="domain"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="DomainName"/></a><br/>
															</td>
															<td width="1%"></td>
															<td class="writeinline">
																<xsl:value-of select="../../Features/Feature[Disabled = 'False' and SourceFlag = 'Domain' and SourceName = $domain]/Description"/><br/>
															</td>
														</tr>
														<tr>
															<td class="smalltext">Domain Name</td>
															<td widht="1%"></td>
															<td class="smalltext">Granted Power</td>
														</tr>
													</xsl:for-each>
												</table>
											</td>
										</tr>
									</xsl:if>
									<xsl:if test="../../SpecialistSchools/SpecialistSchool[ClassName = $class]">
										<tr>
											<td>
												<table width="100%" cellspacing="0" cellpadding="0" border="0">
													<tr>
														<td class="largetext" align="left" colspan="3">Specialty School</td>
													</tr>
													<tr>
														<td class="writeinline" width="33%" align="center">
															<xsl:for-each select="../../SpecialistSchools/SpecialistSchool[ClassName = $class]">
																<a target="school"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SchoolName"/></a>
															</xsl:for-each>
														</td>
														<xsl:for-each select="../../ProhibitedSchools/ProhibitedSchool[ClassName = $class]">
															<td width="1%"></td>
															<td class="writeinline" width="32%" align="center">
																<a target="school"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="SchoolName"/></a>
															</td>
														</xsl:for-each>
													</tr>
													<tr>
														<td class="smalltext" align="center" width="33%">SPECIALTY SCHOOL (+2 BONUS ON SPELLCRAFT<br/>CHECKS TO LEARN SPELLS FROM THIS<br/>CHOSEN SCHOOL)</td>
														<xsl:for-each select="../../ProhibitedSchools/ProhibitedSchool[ClassName = $class]">
															<td width="1%"></td>
															<td class="smalltext" align="center" width="32%" valign="top">Prohibited School</td>
														</xsl:for-each>
													</tr>
												</table>
											</td>
										</tr>
									</xsl:if>
									
									<!-- Spells Known/Per Day -->
									<tr>
										<td>
											<table cellSpacing="0" cellPadding="0" width="100%" border="0">
												<tbody>
													<tr class="spellListHeader2">
														<xsl:if test="$UseSpellPoints = 'Yes'">
															<td align="middle"><b>SPELL POINTS</b></td>
														</xsl:if>
														<td style="BORDER-LEFT: black 3px solid"><b>LEVELS</b></td>
														<td align="middle" width="9%"><b>0</b></td>
														<td align="middle" width="9%"><b>1</b></td>
														<td align="middle" width="9%"><b>2</b></td>
														<td align="middle" width="9%"><b>3</b></td>
														<td align="middle" width="9%"><b>4</b></td>
														<td align="middle" width="9%"><b>5</b></td>
														<td align="middle" width="9%"><b>6</b></td>
														<td align="middle" width="9%"><b>7</b></td>
														<td align="middle" width="9%"><b>8</b></td>
														<td align="middle" width="9%"><b>9</b></td>
													</tr>
													<xsl:for-each select="../../SpellCasterInfo/CasterClass">
														<xsl:if test="ClassName = $class">
															<xsl:if test="CasterType = 'Known'">
																<tr class="spellListHeaderPerDay">
																	<xsl:if test="$UseSpellPoints = 'Yes'">
																		<td align="middle"></td>
																	</xsl:if>
																	<td><b>Known:</b></td>
																	<xsl:for-each select="../../SpellCasterInfo/CasterClass">
																		<xsl:if test="ClassName = $class">
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK0 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK0"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK1 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK1"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK2 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK2"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK3 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK3"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK4 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK4"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK5 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK5"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK6 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK6"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK7 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK7"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK8 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK8"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																			<td align="middle">
																				<xsl:choose>
																				<xsl:when test="SpellsKnown/SK9 = '0'">
																					—
																				</xsl:when>
																				<xsl:otherwise>
																					<xsl:value-of select="SpellsKnown/SK9"/>
																				</xsl:otherwise>
																				</xsl:choose>
																			</td>
																		</xsl:if>
																	</xsl:for-each>
																</tr>
															</xsl:if>
														</xsl:if>
													</xsl:for-each>
													
													<tr class="spellListHeaderPerDay">
														<xsl:if test="$UseSpellPoints = 'Yes'">
															<td align="middle">
																<xsl:for-each select="../../SpellCasterInfo/CasterClass">
																	<xsl:if test="ClassName = $class">
																		<xsl:value-of select="SpellPoints"/>
																	</xsl:if>
																</xsl:for-each>
															</td>
														</xsl:if>
														<td><b>Per Day:</b></td>
														<xsl:for-each select="../../SpellCasterInfo/CasterClass">
															<xsl:if test="ClassName = $class">
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD0 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD0"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD0 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD0"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD1 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD1"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD1 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD1"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD2 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD2"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD2 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD2"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD3 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD3"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD3 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD3"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD4 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD4"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD4 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD4"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD5 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD5"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD5 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD5"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD6 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD6"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD6 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD6"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD7 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD7"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD7 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD7"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD8 = '0'">
																		—
																		</xsl:when>
																		<xsl:otherwise>
																		<xsl:value-of select="SpellsPerDay/ClassSPD/SPD8"/>
																		<xsl:if test="SpellsPerDay/DomainSPD/SPD8 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD8"/></xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
																<td align="middle">
																	<xsl:choose>
																		<xsl:when test="SpellsPerDay/ClassSPD/SPD9 = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="SpellsPerDay/ClassSPD/SPD9"/>
																			<xsl:if test="SpellsPerDay/DomainSPD/SPD9 != '0'">+<xsl:value-of select="SpellsPerDay/DomainSPD/SPD9"/>
																			</xsl:if>
																		</xsl:otherwise>
																	</xsl:choose>
																</td>
															</xsl:if>
														</xsl:for-each>	
													</tr>
													
													<tr class="spellListHeaderPerDay">
													<xsl:if test="$UseSpellPoints = 'Yes'">
														<td align="middle"></td>
													</xsl:if>
													<td><b>Save:</b></td>
													<xsl:for-each select="../../SpellCasterInfo/CasterClass">
														<xsl:if test="ClassName = $class">
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD0 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS0"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD1 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS1"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD2 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS2"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD3 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS3"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD4 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS4"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD5 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS5"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD6 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS6"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD7 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS7"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD8 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS8"/></xsl:otherwise>
															</xsl:choose>
														</td>
														<td align="middle">
															<xsl:choose>
															<xsl:when test="SpellsPerDay/ClassSPD/SPD9 = '0'">—</xsl:when>
															<xsl:otherwise><xsl:value-of select="SpellSaves/SS9"/></xsl:otherwise>
															</xsl:choose>
														</td>
														</xsl:if>
													</xsl:for-each>
													</tr>
													
													<xsl:for-each select="../../SpellCasterInfo/CasterClass">
														<xsl:if test="ClassName = $class">
															<xsl:if test="SpellCasterNotes != ''">
																<tr class="spellListHeaderPerDay">
																	<xsl:if test="$UseSpellPoints = 'Yes'">
																		<td align="middle"></td>
																	</xsl:if>
																	<td valign="top">
																		<b>Notes: </b>
																	</td>
																	<td colspan="10">
																		<xsl:value-of select="SpellCasterNotes"/>
																	</td>
																</tr>
															</xsl:if>
														</xsl:if>
													</xsl:for-each>
												</tbody>
											</table>
										</td>
									</tr>
									<!-- Spells Known/Per Day -->
									
									<!-- Spell Levels -->
									<xsl:choose>
										<xsl:when test="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/MemorizedSpells  and $UseSpellsPrepared = 'Yes'">
											<xsl:for-each select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/MemorizedSpells">
												<xsl:sort select="SlotLevel"/>
												<xsl:variable name="level" select="SlotLevel"/>
												<tr>
													<td>
														<table width="100%" cellspacing="0" cellpadding="0">
															<tr class="headline">
																<td height="22" align="center">
																	<xsl:value-of select="SlotLevel"/>
																	<xsl:choose>
																	<xsl:when test="SlotLevel = '0'"/>
																	<xsl:when test="SlotLevel = '1'">st</xsl:when>
																	<xsl:when test="SlotLevel = '2'">nd</xsl:when>
																	<xsl:when test="SlotLevel = '3'">rd</xsl:when>
																	<xsl:otherwise>th</xsl:otherwise>
																	</xsl:choose>
																	Level
																	<xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> Spells
																</td>
															</tr>
															<tr>
																<td height="5"></td>
															</tr>
														</table>
													</td>
												</tr>
												<tr>
													<td>
														<table width="100%" cellspacing="0" cellpadding="0">
															<tr class="spellListHeader">
															<td class="v6w" align="middle">
																<b>PREP</b>
															</td>
															<td class="v6w" align="middle">
																<b>SPELL NAME</b>
															</td>
															<td class="v6w" align="middle">
																<b>VSM</b>
															</td>
															<td class="v6w" align="middle">
																<b>DC</b>
															</td>
															<td class="v6w" align="middle">
																<b>SR</b>
															</td>
															<td class="v6w" align="middle">
																<b>CASTING</b>
															</td>
															<td class="v6w" align="middle">
																<b>RANGE</b>
															</td>
															<td class="v6w" align="middle">
																<b>DURATION</b>
															</td>
															<td class="v6w" align="middle">
																<b>SAVE</b>
															</td>
															<td class="v6w" align="middle">
																<b>SOURCE</b>
															</td>
															</tr>
															<tr>
															<td width="4%"></td>
															<td width="20%"></td>
															<td width="5%"></td>
															<td width="3%"></td>
															<td width="6%"></td>
															<td width="8%"></td>
															<td width="14%"></td>
															<td width="19%"></td>
															<td width="10%"></td>
															<td width="10%"></td>
															</tr>
															
															<xsl:for-each select="MemorizedSpell">
															<xsl:sort select="SpellName"/>
															<xsl:variable name="spellname" select="SpellName"/>
															<!-- Spell -->
															<tr class="spelltext">
																<xsl:if test="position() mod 2 = 0">
																	<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
																</xsl:if>
																<td align="middle" valign="top">
																	<br/>
																</td>
																<td valign="top">
																	<a target="spell">
																		<xsl:attribute name="href">
																		<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/HelpPage"/>
																		</xsl:attribute>
																		<b><xsl:value-of select="SpellName"/></b>
																	</a>
																	<xsl:if test="MetaTags">
																		(<xsl:value-of select="MetaTags"/>)
																	</xsl:if>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Components"/>
																</td>
											                    <xsl:variable name="school" select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/School"/>
											                    <xsl:variable name="subschool" select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/subSchool"/>
											                    <xsl:variable name="descriptor" select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Descriptors"/>
																<xsl:variable name="savemod1" select="sum(/CharacterXMLDataset/Character/MagicModifiers/MagicModifier[Valid = 'True' and Enabled = 'True' and FocusName = $school and contains(SystemElement, ' DC ')]/ModifierValue)"/>
																<xsl:variable name="savemod2" select="sum(/CharacterXMLDataset/Character/MagicModifiers/MagicModifier[Valid = 'True' and Enabled = 'True' and contains($descriptor, FocusName) and contains(SystemElement, ' DC ')]/ModifierValue)"/>
																<xsl:variable name="savemod3" select="sum(/CharacterXMLDataset/Character/MagicModifiers/MagicModifier[Valid = 'True' and Enabled = 'True' and FocusName = $subschool and contains(SystemElement, ' DC ')]/ModifierValue)"/>
																<td align="middle" valign="top">
																	<xsl:choose>
																	<xsl:when test="$level = '0'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS0 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '1'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS1 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '2'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS2 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '3'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS3 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '4'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS4 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '5'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS5 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '6'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS6 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '7'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS7 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '8'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS8 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '9'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS9 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	</xsl:choose>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/SpellResistance"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Time"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Range"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Duration"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/SavingThrow"/>
																	<br/>
																</td>
																<td align="left" valign="top">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Sourcebook"/>
																	<xsl:text> </xsl:text>
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/PageNo"/>
																	<br/>
																</td>
															</tr>
															<tr class="spelltext">
																<xsl:if test="position() mod 2 = 0">
																	<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
																</xsl:if>
																<td></td>
																<td colspan="9">
																	<xsl:value-of select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]/Spell[SpellName = $spellname]/Description"/>
																</td>
															</tr>
															<!-- /Spell -->
															</xsl:for-each>
														</table>
													</td>
												</tr>
											</xsl:for-each>
										</xsl:when>
										
										<xsl:otherwise>
											<xsl:for-each select="/CharacterXMLDataset/Character/Spells/ClassSpells[ClassName = $class]">
												<xsl:sort select="ClassName"/>
												<xsl:sort select="SpellLevel"/>
												<xsl:variable name="level" select="SpellLevel"/>
												<tr>
													<td>
														<table width="100%" cellspacing="0" cellpadding="0">
															<tr class="headline">
																<td height="22" align="center">
																	<xsl:value-of select="SpellLevel"/>
																	<xsl:choose>
																	<xsl:when test="SpellLevel = '0'"/>
																	<xsl:when test="SpellLevel = '1'">st</xsl:when>
																	<xsl:when test="SpellLevel = '2'">nd</xsl:when>
																	<xsl:when test="SpellLevel = '3'">rd</xsl:when>
																	<xsl:otherwise>th</xsl:otherwise>
																	</xsl:choose>
																	Level
																	<xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> Spells
																</td>
															</tr>
															<tr>
																<td height="5"></td>
															</tr>
														</table>
													</td>
												</tr>
												<tr>
													<td>
														<table width="100%" cellspacing="0" cellpadding="0">
															<tr class="spellListHeader">
															<td class="v6w" align="middle">
																<b>PREP</b>
															</td>
															<td class="v6w" align="middle">
																<b>SPELL NAME</b>
															</td>
															<td class="v6w" align="middle">
																<b>VSM</b>
															</td>
															<td class="v6w" align="middle">
																<b>DC</b>
															</td>
															<td class="v6w" align="middle">
																<b>SR</b>
															</td>
															<td class="v6w" align="middle">
																<b>CASTING</b>
															</td>
															<td class="v6w" align="middle">
																<b>RANGE</b>
															</td>
															<td class="v6w" align="middle">
																<b>DURATION</b>
															</td>
															<td class="v6w" align="middle">
																<b>SAVE</b>
															</td>
															<td class="v6w" align="middle">
																<b>SOURCE</b>
															</td>
															</tr>
															<tr>
															<td width="4%"></td>
															<td width="20%"></td>
															<td width="5%"></td>
															<td width="3%"></td>
															<td width="6%"></td>
															<td width="8%"></td>
															<td width="14%"></td>
															<td width="19%"></td>
															<td width="10%"></td>
															<td width="10%"></td>
															</tr>
															
															<xsl:for-each select="Spell">
															<xsl:sort select="SpellName"/>
															<!-- Spell -->
															<tr class="spelltext">
																<xsl:if test="position() mod 2 = 0">
																	<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
																</xsl:if>
																<td align="middle" valign="top">
																	<br/>
																</td>
																<td valign="top">
																	<a target="spell">
																		<xsl:attribute name="href">
																		<xsl:value-of select="HelpPage"/>
																		</xsl:attribute>
																		<b><xsl:value-of select="SpellName"/></b>
																	</a>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="Components"/>
																</td>
																<xsl:variable name="school" select="School"/>
																<xsl:variable name="subschool" select="subSchool"/>
																<xsl:variable name="descriptor" select="Descriptors"/>
																<xsl:variable name="savemod1" select="sum(/CharacterXMLDataset/Character/MagicModifiers/MagicModifier[Valid = 'True' and Enabled = 'True' and FocusName = $school and contains(SystemElement, ' DC ')]/ModifierValue)"/>
																<xsl:variable name="savemod2" select="sum(/CharacterXMLDataset/Character/MagicModifiers/MagicModifier[Valid = 'True' and Enabled = 'True' and contains($descriptor, FocusName) and contains(SystemElement, ' DC ')]/ModifierValue)"/>
																<xsl:variable name="savemod3" select="sum(/CharacterXMLDataset/Character/MagicModifiers/MagicModifier[Valid = 'True' and Enabled = 'True' and FocusName = $subschool and contains(SystemElement, ' DC ')]/ModifierValue)"/>
																<td align="middle" valign="top">
																	<xsl:choose>
																	<xsl:when test="$level = '0'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS0 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '1'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS1 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '2'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS2 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '3'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS3 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '4'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS4 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '5'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS5 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '6'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS6 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '7'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS7 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '8'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS8 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	<xsl:when test="$level = '9'">
																		<xsl:value-of select="/CharacterXMLDataset/Character/SpellCasterInfo/CasterClass[ClassName = $class]/SpellSaves/SS9 + $savemod1 + $savemod2 + $savemod3"/>
																	</xsl:when>
																	</xsl:choose>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="SpellResistance"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="Time"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="Range"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="Duration"/>
																	<br/>
																</td>
																<td align="middle" valign="top">
																	<xsl:value-of select="SavingThrow"/>
																	<br/>
																</td>
																<td align="left" valign="top">
																	<xsl:value-of select="Sourcebook"/>
																	<xsl:text> </xsl:text>
																	<xsl:value-of select="PageNo"/>
																	<br/>
																</td>
															</tr>
															<tr class="spelltext">
																<xsl:if test="position() mod 2 = 0">
																	<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
																</xsl:if>
																<td></td>
																<td colspan="9">
																	<xsl:value-of select="Description"/>
																</td>
															</tr>
															<!-- /Spell -->
															</xsl:for-each>
														</table>
													</td>
												</tr>
											</xsl:for-each>
										</xsl:otherwise>
									</xsl:choose>
									<!-- /Spell Levels -->
									<!-- /Spells -->
								</table>
							</td>
						</tr>
					</table>
					<!-- /Caster Class -->
				</xsl:for-each>
				
				
				<xsl:for-each select="Powers/ClassPowers[not(ClassName = preceding-sibling::ClassPowers/ClassName)]">
					<!-- Manifester Class -->
					<xsl:variable name="class" select="ClassName"/>					
					<table width="100%" cellspacing="0" cellpadding="0">
						<tr>
							<td width="50%" rowspan="4" valign="top">
								<table width="100%" cellspacing="0" cellpadding="0">
									<!-- Powers -->
									<tr>
										<td>
											<table width="100%" cellspacing="0" cellpadding="0">
												<tr class="headline">
													<td height="22" align="center">
														<xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> Powers
													</td>
												</tr>
												<tr>
													<td height="5"></td>
												</tr>
											</table>
										</td>
									</tr>
									
									<!-- Manifester Discipline -->
									<xsl:if test="/CharacterXMLDataset/Character/PsionicSpecializations/PsionicSpecialization[ClassName = $class]">
										<tr>
											<td>
												<table cellspacig="0" cellpadding="0" border="0" width="50%">
													<tr>
														<td class="largetext">
															<b>PRIMARY DISCIPLINE</b>
														</td>
														<td width="1%"></td>
														<td class="writeinline">
															<xsl:value-of select="/CharacterXMLDataset/Character/PsionicSpecializations/PsionicSpecialization[ClassName = $class]/PsionicSpecializationName"/>
														</td>
													</tr>
												</table>
											</td>
										</tr>
									</xsl:if>
									<!-- /Manifester Discipline-->
									
									<!-- Power Known -->
									<tr>
										<td>
											<table width="100%" cellspacing="0" cellpadding="0" border="0">
												<tr>
													<td width="20%" valign="top">
														<table width="100%" cellspacing="0" cellpadding="0" border="0">
															<tr>
																<td valign="top" class="largetext"><b>POWER POINTS</b></td>
																<td width="1%"></td>
																<td valign="top" class="writeinline" align="center"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/PowerPoints"/></td>
															</tr>
														</table>
													</td>
													<td width="1%"></td>
													<td>
														<table cellSpacing="0" cellPadding="0" width="100%" border="0">
															<tbody>
																<tr class="spellListHeader2">
																	<td style="BORDER-LEFT: black 3px solid" width="14%"><b>LEVELS</b></td>
																	<td align="middle" width="9%"><b>1</b></td>
																	<td align="middle" width="9%"><b>2</b></td>
																	<td align="middle" width="9%"><b>3</b></td>
																	<td align="middle" width="9%"><b>4</b></td>
																	<td align="middle" width="9%"><b>5</b></td>
																	<td align="middle" width="9%"><b>6</b></td>
																	<td align="middle" width="9%"><b>7</b></td>
																	<td align="middle" width="9%"><b>8</b></td>
																	<td align="middle" width="9%"><b>9</b></td>
																</tr>
																<tr class="spellListHeaderPerDay">
																	<td><b>Known:</b></td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 1]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 1]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 2]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 2]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 3]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 3]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 4]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 4]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 5]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 5]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 6]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 6]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 7]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 7]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 8]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 8]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 9]/Power) = '0'">
																			—
																		</xsl:when>
																		<xsl:otherwise>
																			<xsl:value-of select="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 9]/Power)"/>
																		</xsl:otherwise>
																		</xsl:choose>
																	</td>
																</tr>
																
																<tr class="spellListHeaderPerDay">
																<td><b>Save:</b></td>
																<xsl:for-each select="../../ManifesterInfo/ManifesterClass">
																	<xsl:if test="ClassName = $class">
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 1]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS1"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 2]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS2"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 3]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS3"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 4]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS4"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 5]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS5"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 6]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS6"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 7]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS7"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 8]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS8"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	<td align="middle">
																		<xsl:choose>
																		<xsl:when test="count(/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class and PowerLevel = 9]/Power) = 0">—</xsl:when>
																		<xsl:otherwise><xsl:value-of select="PowerSaves/PS9"/></xsl:otherwise>
																		</xsl:choose>
																	</td>
																	</xsl:if>
																</xsl:for-each>
																</tr>
																
																<xsl:for-each select="../../ManifesterInfo/ManifesterClass">
																	<xsl:if test="ClassName = $class">
																		<xsl:if test="ManifesterNotes != ''">
																			<tr class="spellListHeaderPerDay">
																				<td valign="top">
																					<b>Notes: </b>
																				</td>
																				<td colspan="10">
																					<xsl:value-of select="ManifesterNotes"/>
																				</td>
																			</tr>
																		</xsl:if>
																	</xsl:if>
																</xsl:for-each>
															</tbody>
														</table>
													</td>
												</tr>
											</table>
										</td>
									</tr>
									<!-- Power Known -->
									
									<!-- Power Levels -->
									<xsl:for-each select="/CharacterXMLDataset/Character/Powers/ClassPowers[ClassName = $class]">
										<xsl:sort select="ClassName"/>
										<xsl:sort select="PowerLevel"/>
										<xsl:variable name="level" select="PowerLevel"/>
										<tr>
											<td>
											
												<table width="100%" cellspacing="0" cellpadding="0">
													<tr class="headline">
														<td height="22" align="center">
															<xsl:value-of select="PowerLevel"/>
															<xsl:choose>
																<xsl:when test="PowerLevel = '0'"/>
																<xsl:when test="PowerLevel = '1'">st</xsl:when>
																<xsl:when test="PowerLevel = '2'">nd</xsl:when>
																<xsl:when test="PowerLevel = '3'">rd</xsl:when>
																<xsl:otherwise>th</xsl:otherwise>
															</xsl:choose>
															Level
															<xsl:value-of select="translate(ClassName, $lcletters, $ucletters)"/> Powers
														</td>
													</tr>
													<tr>
														<td height="5"></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td>
												<table width="100%" cellspacing="0" cellpadding="0">
													<tr class="spellListHeader">
														<td class="v6w" align="middle"><b>POWER NAME</b></td>
														<td class="v6w" align="middle"><b>DISPLAY</b></td>
														<td class="v6w" align="middle"><b>DC</b></td>
														<td class="v6w" align="middle"><b>PR</b></td>
														<td class="v6w" align="middle"><b>MANIFESTING</b></td>
														<td class="v6w" align="middle"><b>RANGE</b></td>
														<td class="v6w" align="middle"><b>DURATION</b></td>
														<td class="v6w" align="middle"><b>SAVE</b></td>
														<td class="v6w" align="middle"><b>SOURCE</b></td>
													</tr>
													<tr>
														<td width="20%"></td>
														<td width="5%"></td>
														<td width="3%"></td>
														<td width="6%"></td>
														<td width="8%"></td>
														<td width="14%"></td>
														<td width="19%"></td>
														<td width="10%"></td>
														<td width="10%"></td>
													</tr>
													
													<xsl:for-each select="Power">
													<xsl:sort select="PowerName"/>
													<!-- Power -->
													<tr class="smalltext">
														<xsl:if test="position() mod 2 = 0">
															<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
														</xsl:if>
														<td valign="top">
															<a target="power"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="PowerName"/></a><br/>
														</td>
														<td align="middle" valign="top"><xsl:value-of select="Display"/></td>
														<xsl:variable name="discipline" select="Discipline"/>
														<xsl:variable name="subdiscipline" select="Subdiscipline"/>
														<xsl:variable name="descriptor" select="Descriptors"/>
														<xsl:variable name="savemod1" select="sum(/CharacterXMLDataset/Character/PsionicModifiers/PsionicModifier[Valid = 'True' and Enabled = 'True' and FocusName = $discipline and contains(SystemElement, ' DC ')]/ModifierValue)"/>
														<xsl:variable name="savemod2" select="sum(/CharacterXMLDataset/Character/PsionicModifiers/PsionicModifier[Valid = 'True' and Enabled = 'True' and contains($descriptor, FocusName) and contains(SystemElement, ' DC ')]/ModifierValue)"/>
														<xsl:variable name="savemod3" select="sum(/CharacterXMLDataset/Character/PsionicModifiers/PsionicModifier[Valid = 'True' and Enabled = 'True' and FocusName = $subdiscipline and contains(SystemElement, ' DC ')]/ModifierValue)"/>
														<td align="middle" valign="top">
															<xsl:choose>
																<xsl:when test="$level = '0'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS0 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '1'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS1 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '2'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS2 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '3'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS3 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '4'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS4 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '5'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS5 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '6'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS6 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '7'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS7 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '8'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS8 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
																<xsl:when test="$level = '9'"><xsl:value-of select="/CharacterXMLDataset/Character/ManifesterInfo/ManifesterClass[ClassName = $class]/PowerSaves/PS9 + $savemod1 + $savemod2 + $savemod3"/></xsl:when>
															</xsl:choose>
															<br/>
														</td>
														<td align="middle" valign="top">
															<xsl:value-of select="PowerResistance"/><br/>
														</td>
														<td align="middle" valign="top">
															<xsl:value-of select="Time"/><br/>
														</td>
														<td align="middle" valign="top">
															<xsl:value-of select="Range"/><br/>
														</td>
														<td align="middle" valign="top">
															<xsl:value-of select="Duration"/><br/>
														</td>
														<td align="middle" valign="top">
															<xsl:value-of select="SavingThrow"/><br/>
														</td>
														<td align="left" valign="top">
															<xsl:value-of select="Sourcebook"/><xsl:text> </xsl:text><xsl:value-of select="PageNo"/><br/>
														</td>
													</tr>
													<tr class="spelltext">
														<xsl:if test="position() mod 2 = 0">
															<xsl:attribute name="bgcolor">#DDDDDD</xsl:attribute>
														</xsl:if>
														<td colspan="9">
															<xsl:value-of select="Description"/>
														</td>
													</tr>
													<!-- /Power -->
													</xsl:for-each>
												</table>
											</td>
										</tr>
									</xsl:for-each>
									<!-- /Power Levels -->
									<!-- /Powers -->
								</table>
							</td>
						</tr>
					</table>
					<!-- /Manifester Class -->
				</xsl:for-each>
				
				<xsl:if test="Notes != ''">
					<table cellSpacing="0" cellPadding="2" width="100%" border="0">
						<tbody>
							<tr>
								<td>
									<table width="100%" cellspacing="0" cellpadding="0">
										<tr class="headline">
											<td height="22" align="center">
												Notes
											</td>
										</tr>
										<tr>
											<td height="5"></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td class="box" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid">
									<xsl:call-template name="format-literal-content-helper">
										<xsl:with-param name="text" select="Notes"/>
									</xsl:call-template>
									<br/>
								</td>
							</tr>
						</tbody>
					</table>
				</xsl:if>
				
				<xsl:if test="Background != ''">
					<table cellSpacing="0" cellPadding="2" width="100%" border="0">
						<tbody>
							<tr>
								<td>
									<table width="100%" cellspacing="0" cellpadding="0">
										<tr class="headline">
											<td height="22" align="center">
												Background
											</td>
										</tr>
										<tr>
											<td height="5"></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td class="box" style="BORDER-RIGHT: black 1px solid; BORDER-TOP: black 1px solid; BORDER-LEFT: black 1px solid; BORDER-BOTTOM: black 1px solid">
									<xsl:call-template name="format-literal-content-helper">
										<xsl:with-param name="text" select="Background"/>
									</xsl:call-template>
									<br/>
								</td>
							</tr>
						</tbody>
					</table>
				</xsl:if>
				
			</body>
		</html>
	</xsl:template>
	
	<xsl:template name="equipment">
		<xsl:param name="container" select="1"/>
		<xsl:param name="name" select="1"/>
		<tr class="containerHeader">
			<td colspan="2" align="middle"><xsl:value-of select="$name"/></td>
		</tr>
		<tr class="inventoryHeader">
			<td>Item</td>
			<td>Weight</td>
		</tr>
		<xsl:for-each select="/CharacterXMLDataset/Character/Inventory/InventoryItem[ContainerKey = $container]">
			<xsl:sort select="ItemName"/>
			<tr>
				<td class="writeinline">
					<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ItemName"/></a>
					<xsl:if test="Charges"><xsl:text> </xsl:text>(<xsl:value-of select="Charges"/> charges)</xsl:if>
					<xsl:if test="Quantity &gt; 1"><xsl:text> </xsl:text>x<xsl:value-of select="Quantity"/></xsl:if>
					<br/>
				</td>
				<td class="writeinline">
					<xsl:choose><xsl:when test="ItemWeight != ''"><xsl:value-of select="ItemWeight"/></xsl:when><xsl:otherwise>0 lb.</xsl:otherwise></xsl:choose>
				</td>
			</tr>
		</xsl:for-each>
	</xsl:template>
	
	<xsl:template name="emptyinventory">
		<xsl:param name="count" select="1"/>
		<xsl:if test="$count > 0">
			<tr>
				<td align="center" style="border: 1px solid black;" class="v7" width="80%">
					<br/>
				</td>
				<td align="center" style="border: 1px solid black;" class="v7" width="19%">
					<br/>
				</td>
			</tr>
			<xsl:call-template name="emptyinventory">
				<xsl:with-param name="count" select="$count - 1"/>
			</xsl:call-template>
		</xsl:if>
	</xsl:template>
	
	<xsl:template name="assets">
		<tr class="containerHeader">
			<td colspan="2" align="middle">Assets</td>
		</tr>
		<tr class="inventoryHeader">
			<td>Item</td>
			<td>Weight</td>
		</tr>
		<xsl:for-each select="/CharacterXMLDataset/Character/Assets/AssetItem">
			<xsl:sort select="ItemName"/>
			<tr>
				<td class="writeinline">
					<a target="item"><xsl:attribute name="href"><xsl:value-of select="HelpPage"/></xsl:attribute><xsl:value-of select="ItemName"/></a>
					<xsl:if test="Charges"><xsl:text> </xsl:text>(<xsl:value-of select="Charges"/> charges)</xsl:if>
					<xsl:if test="Quantity &gt; 1"><xsl:text> </xsl:text>x<xsl:value-of select="Quantity"/></xsl:if>
					<br/>
				</td>
				<td class="writeinline">
					<xsl:choose><xsl:when test="ItemWeight != ''"><xsl:value-of select="ItemWeight"/></xsl:when><xsl:otherwise>0 lb.</xsl:otherwise></xsl:choose>
				</td>
			</tr>
		</xsl:for-each>
	</xsl:template>
	
</xsl:stylesheet>