using System;

namespace Som13 {
	static class GlobalFuncs {
		public static string	_command_name(  ) {
			string	name = null;
			if ( GlobalVars.command_name != null ) {
				return GlobalVars.command_name;
			}
			name = "Central Command";
			GlobalVars.command_name = name;
			return name;
		}

		public static UNKNOWN	_station_name(  ) {
			if ( GlobalVars.station_name != null ) {
				return GlobalVars.station_name;
			}
			if ( GlobalVars.config && GlobalVars.config.station_name != null ) {
				GlobalVars.station_name = GlobalVars.config.station_name;
			} else {
				GlobalVars.station_name = GlobalFuncs.new_station_name();
			}
			if ( GlobalVars.config && GlobalVars.config.server_name != null ) {
				Game.name = "" + GlobalVars.config.server_name + ( GlobalVars.config.server_name == GlobalVars.station_name ? "" : ": " + GlobalVars.station_name );
			} else {
				Game.name = GlobalVars.station_name;
			}
			return GlobalVars.station_name;
		}

		public static string	_syndicate_name(  ) {
			string	name = null;
			if ( GlobalVars.syndicate_name != null ) {
				return GlobalVars.syndicate_name;
			}
			name = "";
			name += Rand.pick(new object [] { "Clandestine", "Prima", "Blue", "Zero-G", "Max", "Blasto", "Waffle", "North", "Omni", "Newton", "Cyber", "Bonk", "Gene", "Gib" });
			if ( Rand.chance( 80 ) != null ) {
				name += " ";
				if ( Rand.chance( 60 ) != null ) {
					name += Rand.pick(new object [] { "Syndicate", "Consortium", "Collective", "Corporation", "Group", "Holdings", "Biotech", "Industries", "Systems", "Products", "Chemicals", "Enterprises", "Family", "Creations", "International", "Intergalactic", "Interplanetary", "Foundation", "Positronics", "Hive" });
				} else {
					name += Rand.pick(new object [] { "Syndi", "Corp", "Bio", "System", "Prod", "Chem", "Inter", "Hive" });
					name += Rand.pick(new object [] { "", "-" });
					name += Rand.pick(new object [] { "Tech", "Sun", "Co", "Tek", "X", "Inc", "Code" });
				}
			} else {
				name += Rand.pick(new object [] { "-", "*", "" });
				name += Rand.pick(new object [] { "Tech", "Sun", "Co", "Tek", "X", "Inc", "Gen", "Star", "Dyne", "Code", "Hive" });
			}
			GlobalVars.syndicate_name = name;
			return name;
		}

		public static int	above_neck( UNKNOWN [object Object] =null ) {
			ByTable	zones = null;
			zones = new ByTable(new object [] {"head","mouth","eyes"});
			if ( zones.Find( zone ) != null ) {
				return 1;
			} else {
				return 0;
			}
		}

		public static dynamic	active_ais( UNKNOWN [object Object] =null ) {
			dynamic	A = null;
			UNKNOWN _default;
			if ( check_mind == null != null ) {
				check_mind = 0;
			}
			undefined = new ByTable();
			A = null;
			foreach (_ in GlobalVars.living_mob_list ) {
				A = undefined;
				if ( !( A instanceof Mob_Living_Silicon_Ai ) != null ) {
					continue;
				}
				if ( A.stat == 2 != null ) {
					continue;
				}
				if ( A.control_disabled == 1 != null ) {
					continue;
				}
				if ( check_mind != null ) {
					if ( !A.mind != null ) {
						continue;
					}
				}
				undefined += A;
			};
			return undefined;
			return _default;
		}

		public static dynamic	active_free_borgs(  ) {
			dynamic	R = null;
			UNKNOWN _default;
			undefined = new ByTable();
			R = null;
			foreach (_ in GlobalVars.living_mob_list ) {
				R = undefined;
				if ( !( R instanceof Mob_Living_Silicon_Robot ) != null ) {
					continue;
				}
				if ( R.connected_ai != null ) {
					continue;
				}
				if ( R.stat == 2 != null ) {
					continue;
				}
				if ( R.emagged || R.scrambledcodes || R.syndicate != null ) {
					continue;
				}
				undefined += R;
			};
			return _default;
		}

		public static dynamic	add_logs( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	newhealthtxt = null;
			if ( _object == null != null ) {
				_object = null;
			}
			if ( addition == null != null ) {
				addition = null;
			}
			newhealthtxt = "";
			if ( target && target instanceof Mob_Living != null ) {
				L = target;
				newhealthtxt = " (NEWHP: " + L.health + ")";
			}
			if ( user && GlobalVars.undefined( user ) != null ) {
				user.attack_log += "[" + GlobalFuncs.time_stamp() + "] <font color='red'>Has " + what_done + " " + ( target ? "" + target.name + ( GlobalVars.undefined( target ) && target.ckey ? "(" + target.ckey + ")" : "" ) : "NON-EXISTANT SUBJECT" ) + ( _object ? " with " + _object : " " ) + addition + newhealthtxt + "</font>";
			}
			if ( target && GlobalVars.undefined( target ) != null ) {
				target.attack_log += "[" + GlobalFuncs.time_stamp() + "] <font color='orange'>Has been " + what_done + " by " + ( user ? "" + user.name + ( GlobalVars.undefined( user ) && user.ckey ? "(" + user.ckey + ")" : "" ) : "NON-EXISTANT SUBJECT" ) + ( _object ? " with " + _object : " " ) + addition + newhealthtxt + "</font>";
			}
			GlobalFuncs.log_attack( "" + ( user ? "" + user.name + ( GlobalVars.undefined( user ) && user.ckey ? "(" + user.ckey + ")" : "" ) : "NON-EXISTANT SUBJECT" ) + " " + what_done + " " + ( target ? "" + target.name + ( GlobalVars.undefined( target ) && target.ckey ? "(" + target.ckey + ")" : "" ) : "NON-EXISTANT SUBJECT" ) + ( _object ? " with " + _object : " " ) + addition + newhealthtxt );
		}

		public static UNKNOWN	add_lspace( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			while (GlobalVars.undefined( t ) < u) {
				t = " " + t;
			};
			return t;
		}

		public static dynamic	add_note( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	new_ckey = null;
			if ( logged == null != null ) {
				logged = 1;
			}
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalVars.undefined.user.write( "<span class='danger'>Failed to establish database connection.</span>" );
				return;
			}
			if ( !target_ckey != null ) {
				new_ckey = GlobalVars.undefined( GlobalVars.undefined( GlobalVars.undefined.user, "Who would you like to add a note for?", "Enter a ckey", null, null, 4 ) );
				if ( !new_ckey != null ) {
					return;
				}
				new_ckey = GlobalFuncs.sanitizeSQL( new_ckey );
				query_find_ckey = GlobalVars.dbcon.NewQuery( "SELECT ckey FROM " + GlobalFuncs.format_table_name( "player" ) + " WHERE ckey = '" + new_ckey + "'" );
				if ( !query_find_ckey.Execute() != null ) {
					err = query_find_ckey.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR obtaining ckey from player table. Error : [" + err + "]\n" );
					return;
				}
				if ( !query_find_ckey.NextRow() != null ) {
					if ( GlobalVars.undefined( GlobalVars.undefined.user, "" + new_ckey + " has not been seen before, are you sure you want to add them to the watchlist?", "Unknown ckey", "Yes", "No", "Cancel" ) != "Yes" != null ) {
						return;
					}
				}
				target_ckey = new_ckey;
			}
			target_sql_ckey = GlobalFuncs.sanitizeSQL( target_ckey );
			if ( !notetext != null ) {
				notetext = GlobalVars.undefined( GlobalVars.undefined.user, "Write your Note", "Add Note", null, null, 2048 );
				if ( !notetext != null ) {
					return;
				}
			}
			notetext = GlobalFuncs.sanitizeSQL( notetext );
			if ( !timestamp != null ) {
				timestamp = GlobalFuncs.SQLtime();
			}
			if ( !adminckey != null ) {
				adminckey = GlobalVars.undefined.user.ckey;
				if ( !adminckey != null ) {
					return;
				}
			}
			admin_sql_ckey = GlobalFuncs.sanitizeSQL( adminckey );
			if ( !server != null ) {
				if ( GlobalVars.config && GlobalVars.config.server_name != null ) {
					server = GlobalVars.config.server_name;
				}
			}
			server = GlobalFuncs.sanitizeSQL( server );
			query_noteadd = GlobalVars.dbcon.NewQuery( "INSERT INTO " + GlobalFuncs.format_table_name( "notes" ) + " (ckey, timestamp, notetext, adminckey, server) VALUES ('" + target_sql_ckey + "', '" + timestamp + "', '" + notetext + "', '" + admin_sql_ckey + "', '" + server + "')" );
			if ( !query_noteadd.Execute() != null ) {
				err = query_noteadd.$ErrorMsg();
				GlobalFuncs.log_game( "SQL ERROR adding new note to table. Error : [" + err + "]\n" );
				return;
			}
			if ( logged != null ) {
				GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has added a note to " + target_ckey + ": " + notetext );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " has added a note to " + target_ckey + ":<br>" + notetext );
				GlobalFuncs.show_note( target_ckey );
			}
		}

		public static dynamic	add_radio( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( !freq || !radio != null ) {
				return;
			}
			if ( !GlobalVars.all_radios["" + freq] != null ) {
				GlobalVars.all_radios["" + freq] = new ByTable(new object [] {radio});
				return freq;
			}
			GlobalVars.all_radios["" + freq] = GlobalVars.all_radios["" + freq] | radio;
			return freq;
		}

		public static UNKNOWN	add_tspace( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			while (GlobalVars.undefined( t ) < u) {
				t = "" + t + " ";
			};
			return t;
		}

		public static UNKNOWN	add_zero( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			while (GlobalVars.undefined( t ) < u) {
				t = "0" + t;
			};
			return t;
		}

		public static int	AddBan( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	bantimestamp = null;
			if ( temp != null ) {
				GlobalFuncs.UpdateTime();
				bantimestamp = GlobalVars.CMinutes + minutes;
			}
			GlobalVars.Banlist.cd = "/base";
			if ( GlobalVars.Banlist.dir.Find( "" + ckey + computerid ) != null ) {
				GlobalVars.undefined.user.write( "<span class='danger'>Ban already exists.</span>" );
				return 0;
			} else {
				GlobalVars.Banlist.$Add( "" + ckey + computerid );
				GlobalVars.Banlist.cd = "/base/" + ckey + computerid;
				GlobalVars.Banlist.key._GOOFY_LIST_.write( ckey );
				GlobalVars.Banlist.id._GOOFY_LIST_.write( computerid );
				GlobalVars.Banlist.ip._GOOFY_LIST_.write( address );
				GlobalVars.Banlist.reason._GOOFY_LIST_.write( reason );
				GlobalVars.Banlist.bannedby._GOOFY_LIST_.write( bannedby );
				GlobalVars.Banlist.temp._GOOFY_LIST_.write( temp );
				if ( temp != null ) {
					GlobalVars.Banlist.minutes._GOOFY_LIST_.write( bantimestamp );
				}
				if ( !temp != null ) {
					GlobalFuncs.add_note( ckey, "Permanently banned - " + reason, null, bannedby, 0 );
				} else {
					GlobalFuncs.add_note( ckey, "Banned for " + minutes + " minutes - " + reason, null, bannedby, 0 );
				}
			}
			return 1;
		}

		public static UNKNOWN	addtimer( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			Timedevent	_event = null;
			if ( argList == null != null ) {
				argList = new ByTable();
			}
			if ( !GlobalVars.SStimer != null ) {
				return;
			}
			if ( !thingToCall || !procToCall || wait <= 0 != null ) {
				return;
			}
			if ( !GlobalVars.SStimer.can_fire != null ) {
				GlobalVars.SStimer.can_fire = 1;
				GlobalVars.SStimer.next_fire = Game.time + GlobalVars.SStimer.wait;
			}
			_event = new Timedevent();
			_event.thingToCall = thingToCall;
			_event.procToCall = procToCall;
			_event.timeToRun = Game.time + wait;
			_event.argList = argList;
			GlobalVars.SStimer.processing += _event;
			return _event.id;
		}

		public static dynamic	admin_forcemove( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( mover.buckled != null ) {
				mover.buckled.unbuckle_mob();
			}
			if ( mover.buckled_mob != null ) {
				mover.unbuckle_mob.lcall( new ByTable().set( "force", 1 ) );
			}
			mover.loc = newloc;
			mover.$on forcemove( newloc );
		}

		public static int	admin_keyword_to_flag( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	flag = null;
			if ( previous_rights == null != null ) {
				previous_rights = 0;
			}
			flag = 0;
			local _ = GlobalVars.undefined( word ) // Was a switch-case, sorry for the mess.
			if ( _=="buildmode" || _=="build" ) {
				flag = 1;
			} else if ( _=="admin" ) {
				flag = 2;
			} else if ( _=="ban" ) {
				flag = 4;
			} else if ( _=="fun" ) {
				flag = 8;
			} else if ( _=="server" ) {
				flag = 16;
			} else if ( _=="debug" ) {
				flag = 32;
			} else if ( _=="permissions" || _=="rights" ) {
				flag = 128;
			} else if ( _=="possess" ) {
				flag = 64;
			} else if ( _=="stealth" ) {
				flag = 256;
			} else if ( _=="rejuv" || _=="rejuvinate" ) {
				flag = 512;
			} else if ( _=="varedit" ) {
				flag = 1024;
			} else if ( _=="everything" || _=="host" || _=="all" ) {
				flag = 65535;
			} else if ( _=="sound" || _=="sounds" ) {
				flag = 2048;
			} else if ( _=="spawn" || _=="create" ) {
				flag = 4096;
			} else if ( _=="@" || _=="prev" ) {
				flag = previous_rights;
			};
			return flag;
		}

		public static UNKNOWN	admin_keyword_to_path( UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( GlobalVars.undefined( word, 2, GlobalVars.undefined( word, " ", 2, 0 ) ) );
		}

		public static dynamic	AdminCreateVirus( UNKNOWN [object Object] =null ) {
			int	i = null;
			if ( !user != null ) {
				return;
			}
			i = 5;
			D = new Disease_Advance( 0, null );
			D.symptoms = new ByTable();
			symptoms = new ByTable();
			symptoms += "Done";
			symptoms += GlobalVars.list_symptoms.Copy();
			while (1) { // Was a do-while, sorry for the mess.
				if ( user != null ) {
					symptom = GlobalVars.undefined( user, "Choose a symptom to add (" + i + " remaining)", "Choose a Symptom", null, symptoms, 0 );
					if ( GlobalVars.undefined( symptom ) != null ) {
						return;
					} else if ( GlobalVars.undefined( symptom ) != null ) {
						i = 0;
					} else if ( GlobalVars.undefined( symptom ) != null ) {
						S = symptom();
						if ( !D.HasSymptom( S ) != null ) {
							D.symptoms += S;
							i -= 1;
						}
					}
				}
				if (!( i > 0 )) break;
			};
			if ( D.symptoms.len > 0 != null ) {
				new_name = GlobalFuncs.stripped_input( user, "Name your new disease.", "New Name" );
				if ( !new_name != null ) {
					return;
				}
				D.AssignName( new_name );
				D.Refresh();
				AD = null;
				foreach (_ in GlobalVars.SSdisease.processing ) {
					AD = undefined;
					if ( !( AD instanceof Disease_Advance ) != null ) {
						continue;
					}
					AD.Refresh();
				};
				H = null;
				foreach (_ in GlobalFuncs.shuffle( GlobalVars.living_mob_list ) ) {
					H = undefined;
					if ( !( H instanceof Mob_Living_Carbon_Human ) != null ) {
						continue;
					}
					if ( H.z != 1 != null ) {
						continue;
					}
					if ( !H.HasDisease( D ) != null ) {
						H.$ForceContractDisease( D );
						break;
					}
				};
				name_symptoms = new ByTable();
				S = null;
				foreach (_ in D.symptoms ) {
					S = undefined;
					if ( !( S instanceof Symptom ) != null ) {
						continue;
					}
					name_symptoms += S.name;
				};
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( user ) + " has triggered a custom virus outbreak of " + D.name + "! It has these symptoms: " + GlobalFuncs.english_list( name_symptoms ) );
			}
		}

		public static UNKNOWN	adminscrub( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( limit == null != null ) {
				limit = 1024;
			}
			return GlobalVars.undefined( GlobalVars.undefined( GlobalFuncs.strip_html_simple( t ) ), 1, limit );
		}

		public static UNKNOWN	Advance_Mix( UNKNOWN [object Object] =null ) {
			ByTable	diseases = null;
			diseases = new ByTable();
			A = null;
			foreach (_ in D_list ) {
				A = undefined;
				if ( !( A instanceof Disease_Advance ) != null ) {
					continue;
				}
				diseases += A.Copy();
			};
			if ( !diseases.len != null ) {
				return;
			}
			if ( diseases.len <= 1 != null ) {
				return Rand.pick( diseases );
			}
			i = 0;
			while (i < 20 && diseases.len > 1) {
				i++;
				D1 = Rand.pick( diseases );
				diseases -= D1;
				D2 = Rand.pick( diseases );
				D2.Mix( D1 );
			};
			to_return = Rand.pick( diseases );
			to_return.Refresh( 1 );
			return to_return;
		}

		public static int	alien_type_present( UNKNOWN [object Object] =null ) {
			dynamic	A = null;
			A = null;
			foreach (_ in GlobalVars.living_mob_list ) {
				A = undefined;
				if ( !( A instanceof Mob_Living_Carbon_Alien_Humanoid ) != null ) {
					continue;
				}
				if ( !( A instanceof alienpath ) != null ) {
					continue;
				}
				if ( !A.key || A.stat == 2 != null ) {
					continue;
				}
				return 1;
			};
			return 0;
		}

		public static int	alone_in_area( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	our_area = null;
			if ( check_type == null != null ) {
				check_type = Mob_Living_Carbon;
			}
			our_area = GlobalFuncs.get_area_master( the_area );
			C = null;
			foreach (_ in GlobalVars.living_mob_list ) {
				C = undefined;
				if ( !( C instanceof check_type ) != null ) {
					continue;
				}
				if ( C == must_be_alone != null ) {
					continue;
				}
				if ( our_area == GlobalFuncs.get_area_master( C ) != null ) {
					return 0;
				}
			};
			return 1;
		}

		public static int	angle2dir( UNKNOWN [object Object] =null ) {
			degree = GlobalFuncs.SimplifyDegrees( degree );
			if ( degree < 45 != null ) {
				return GlobalVars.NORTH;
			}
			if ( degree < 90 != null ) {
				return GlobalVars.NORTHEAST;
			}
			if ( degree < 135 != null ) {
				return GlobalVars.EAST;
			}
			if ( degree < 180 != null ) {
				return GlobalVars.SOUTHEAST;
			}
			if ( degree < 225 != null ) {
				return GlobalVars.SOUTH;
			}
			if ( degree < 270 != null ) {
				return GlobalVars.SOUTHWEST;
			}
			if ( degree < 315 != null ) {
				return GlobalVars.WEST;
			}
			return 9;
		}

		public static UNKNOWN	angle2text( UNKNOWN [object Object] =null ) {
			return GlobalFuncs.dir2text( GlobalFuncs.angle2dir( degree ) );
		}

		public static dynamic	anim( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			BaseDynamic_Overlay	animation = null;
			if ( sleeptime == null != null ) {
				sleeptime = 0;
			}
			animation = new BaseDynamic_Overlay( location );
			if ( direction != null ) {
				animation.dir = direction;
			}
			animation.icon = a_icon;
			animation.layer = target.layer + 1;
			if ( a_icon_state != null ) {
				animation.icon_state = a_icon_state;
			} else {
				animation.icon_state = "blank";
				animation.master = target;
				GlobalVars.undefined( flick_anim, animation );
			}
			GlobalVars.undefined.sleep( GlobalVars.undefined.max( sleeptime, 15 ) );
			GlobalFuncs.qdel( animation );
		}

		public static UNKNOWN	anyprob( UNKNOWN [object Object] =null ) {
			return Rand.Int( 1, value ) == value;
		}

		public static dynamic	appearance_fullban( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( !M || !M.key != null ) {
				return;
			}
			GlobalVars.appearance_keylist.Add( "" + M.ckey + " ## " + reason );
			GlobalFuncs.appearance_savebanfile();
		}

		public static UNKNOWN	appearance_isbanned( UNKNOWN [object Object] =null ) {
			dynamic	s = null;
			if ( M != null ) {
				s = null;
				foreach (_ in GlobalVars.appearance_keylist ) {
					s = undefined;
					if ( GlobalVars.undefined( s, "" + M.ckey, 1, null ) == 1 != null ) {
						startpos = GlobalVars.undefined( s, "## ", 1, null ) + 3;
						if ( startpos && startpos < GlobalVars.undefined( s ) != null ) {
							text = GlobalVars.undefined( s, startpos, 0 );
							if ( text != null ) {
								return text;
							}
						}
						return "Reason Unspecified";
					}
				};
			}
			return 0;
		}

		public static int	appearance_remove( UNKNOWN [object Object] =null ) {
			int	i = null;
			i = null;
			i = 1;
			while (i <= GlobalVars.undefined( GlobalVars.appearance_keylist )) {
				if ( GlobalVars.undefined( GlobalVars.appearance_keylist[i], "" + X, 1, null ) != null ) {
					GlobalVars.appearance_keylist.Remove( GlobalVars.appearance_keylist[i] );
					GlobalFuncs.appearance_savebanfile();
					return 1;
				}
				i++;
			};
			return 0;
		}

		public static dynamic	appearance_savebanfile(  ) {
			UNKNOWN	S = null;
			S = SaveFile( "data/appearance_full.ban" );
			S["keys" + 0]._GOOFY_LIST_.write( GlobalVars.appearance_keylist );
		}

		public static dynamic	appearance_unban( UNKNOWN [object Object] =null ) {
			GlobalFuncs.appearance_remove( "" + M.ckey );
			GlobalFuncs.appearance_savebanfile();
		}

		public static UNKNOWN	arctan( UNKNOWN [object Object] =null ) {
			UNKNOWN	y = null;
			y = GlobalVars.undefined.arcsin( x / GlobalVars.undefined.sqrt( x * x + 1 ) );
			return y;
		}

		public static dynamic	assign_progress_bar( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( user && user.client && progbar != null ) {
				user.client.images = user.client.images | progbar;
			}
		}

		public static UNKNOWN	AStar( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			Heap	open = null;
			if ( maxnodedepth == null != null ) {
				maxnodedepth = 30;
			}
			if ( adjacent == null != null ) {
				adjacent = typeof( Tile ).GetMethod( "reachableAdjacentTurfs" );
			}
			if ( id == null != null ) {
				id = null;
			}
			if ( exclude == null != null ) {
				exclude = null;
			}
			if ( simulated_only == null != null ) {
				simulated_only = 1;
			}
			if ( maxnodes != null ) {
				if ( GlobalVars.undefined( start, dist )( end ) > maxnodes != null ) {
					return 0;
				}
				maxnodedepth = maxnodes;
			}
			open = new Heap( typeof( GlobalFuncs ).GetMethod( "undefined" ) );
			closed = new List();
			path = null;
			start = GlobalFuncs.get_turf( start );
			if ( !start != null ) {
				return 0;
			}
			open.Insert( new PathNode( start, null, 0, GlobalVars.undefined( start, dist )( end ), 0 ) );
			while (!open.IsEmpty() && !path) {
				cur = open.Pop();
				closed.Add( cur.source );
				closeenough = null;
				if ( mintargetdist != null ) {
					closeenough = GlobalVars.undefined( cur.source, dist )( end ) <= mintargetdist;
				}
				if ( maxnodedepth && cur.nt > maxnodedepth != null ) {
					continue;
				}
				if ( cur.source == end || closeenough != null ) {
					path = new List();
					path.Add( cur.source );
					while (cur.prevNode) {
						cur = cur.prevNode;
						path.Add( cur.source );
					};
					break;
				}
				L = GlobalVars.undefined( cur.source, adjacent )( atom, id, simulated_only );
				T = null;
				foreach (_ in L ) {
					T = undefined;
					if ( ( T == exclude || T ) in closed != null ) {
						continue;
					}
					newg = cur.g + GlobalVars.undefined( cur.source, dist )( T );
					if ( !T.PNode != null ) {
						open.Insert( new PathNode( T, cur, newg, GlobalVars.undefined( T, dist )( end ), cur.nt + 1 ) );
					} else if ( newg < T.PNode.g != null ) {
						T.prevNode = cur;
						T.PNode.g = newg;
						T.PNode.calc_f();
						T.PNode.nt = cur.nt + 1;
						open.ReSort( T.PNode );
					}
				};
			};
			PN = null;
			foreach (_ in open.L ) {
				PN = undefined;
				if ( !( PN instanceof PathNode ) != null ) {
					continue;
				}
				PN.source.PNode = null;
			};
			T = null;
			foreach (_ in closed ) {
				T = undefined;
				T.PNode = null;
			};
			if ( path != null ) {
				i = null;
				i = 1;
				while (i <= path.len / 2) {
					path.$Swap( i, path.len - i + 1 );
					i++;
				};
			}
			return path;
		}

		public static UNKNOWN	attach_spans( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return "" + GlobalFuncs.message_spans_start( spans ) + input + "</span>";
		}

		public static int	attempt_initiate_surgery( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	H = null;
			if ( M instanceof Mob_Living != null ) {
				selected_zone = user.zone_sel.selecting;
				if ( M instanceof Mob_Living_Carbon_Human != null ) {
					H = M;
					affecting = H.get_organ( GlobalFuncs.check_zone( selected_zone ) );
				}
				if ( M.lying || M instanceof Mob_Living_SimpleAnimal_Slime != null ) {
					S = null;
					foreach (_ in M.surgeries ) {
						S = undefined;
						if ( !( S instanceof Surgery ) != null ) {
							continue;
						}
						if ( S.location == selected_zone != null ) {
							current_surgery = S;
						}
					};
					if ( !current_surgery != null ) {
						all_surgeries = GlobalVars.surgeries_list.Copy();
						available_surgeries = new ByTable();
						S = null;
						foreach (_ in all_surgeries ) {
							S = undefined;
							if ( !( S instanceof Surgery ) != null ) {
								continue;
							}
							if ( !S.possible_locs.Find( selected_zone ) != null ) {
								continue;
							}
							if ( affecting && S.requires_organic_bodypart && affecting.status == 2 != null ) {
								continue;
							}
							if ( !S.can_start( user, M ) != null ) {
								continue;
							}
							path = null;
							foreach (_ in S.species ) {
								path = undefined;
								if ( M instanceof path != null ) {
									available_surgeries[S.name] = S;
									break;
								}
							};
						};
						P = GlobalVars.undefined( "Begin which procedure?", "Surgery", null, null, available_surgeries, 4224 );
						if ( P && user && user.Adjacent( M ) && I in user != null ) {
							S = available_surgeries[P];
							procedure = S.type();
							if ( procedure != null ) {
								procedure.location = selected_zone;
								if ( procedure.ignore_clothes || GlobalFuncs.get_location_accessible( M, selected_zone ) != null ) {
									M.surgeries += procedure;
									procedure.organ = affecting;
									user.visible_message( GlobalVars.undefined().item( user ).str( " drapes " ).item( I ).str( " over " ).item( M ).str( "'s " ).item( GlobalFuncs.parse_zone( selected_zone ) ).str( " to prepare for " ).a( procedure.name ).item().str( "." ), GlobalVars.undefined( "<span class='notice'>You drape " ).item( I ).str( " over " ).item( M ).str( "'s " ).item( GlobalFuncs.parse_zone( selected_zone ) ).str( " to prepare for " ).a( procedure.name ).item().str( ".</span>" ) );
									GlobalFuncs.smooth_icon_neighbors.lcall( new ByTable().set( "addition", "Operation type: " + procedure.name + ", location: " + selected_zone ).set( 3, "operated" ).set( 2, M ).set( 1, user ) );
								} else {
									user.write( "<span class='warning'>You need to expose " + M + "'s " + GlobalFuncs.parse_zone( selected_zone ) + " first!</span>" );
								}
							}
						}
					} else if ( !current_surgery.step_in_progress != null ) {
						if ( current_surgery.status == 1 != null ) {
							M.surgeries -= current_surgery;
							user.visible_message( "" + user + " removes the drapes from " + M + "'s " + GlobalFuncs.parse_zone( selected_zone ) + ".", "<span class='notice'>You remove the drapes from " + M + "'s " + GlobalFuncs.parse_zone( selected_zone ) + ".</span>" );
							GlobalFuncs.qdel( current_surgery );
						} else if ( user.get_inactive_hand() instanceof Ent_Item_Weapon_Cautery && current_surgery.can_cancel != null ) {
							M.surgeries -= current_surgery;
							user.visible_message( "" + user + " mends the incision and removes the drapes from " + M + "'s " + GlobalFuncs.parse_zone( selected_zone ) + ".", "<span class='notice'>You mend the incision and remove the drapes from " + M + "'s " + GlobalFuncs.parse_zone( selected_zone ) + ".</span>" );
							GlobalFuncs.qdel( current_surgery );
						} else if ( current_surgery.can_cancel != null ) {
							user.write( "<span class='warning'>You need to hold a cautery in inactive hand to stop " + M + "'s surgery!</span>" );
						}
					}
					return 1;
				}
			}
			return 0;
		}

		public static int	AutoUpdateAI( UNKNOWN [object Object] =null ) {
			int	is_in_use = null;
			is_in_use = 0;
			if ( subject != null != null ) {
				A = null;
				foreach (_ in GlobalVars.ai_list ) {
					A = undefined;
					M = A;
					if ( M.client && M.machine == subject != null ) {
						is_in_use = 1;
						subject.attack_ai( M );
					}
				};
			}
			return is_in_use;
		}

		public static UNKNOWN	AverageColour( UNKNOWN [object Object] =null ) {
			ByTable	colours = null;
			colours = new ByTable();
			x_pixel = null;
			foreach (_ in GlobalVars.undefined( 1, I.Width() ) ) {
				x_pixel = undefined;
				y_pixel = null;
				foreach (_ in GlobalVars.undefined( 1, I.Height() ) ) {
					y_pixel = undefined;
					this_colour = I.GetPixel( x_pixel, y_pixel );
					if ( this_colour != null ) {
						colours.Add( this_colour );
					}
				};
			};
			if ( !colours.len != null ) {
				return;
			}
			final_average = colours[1];
			colour = null;
			foreach (_ in colours - colours[1] ) {
				colour = undefined;
				final_average = GlobalFuncs.BlendRGB( final_average, colour, 1 );
			};
			return final_average;
		}

		public static dynamic	ban_unban_log_save( UNKNOWN [object Object] =null ) {
			GlobalVars.undefined.write( formatted_log, "data/ban_unban_log.txt" );
		}

		public static int	blendMode2iconMode( UNKNOWN [object Object] =null ) {
			local _ = blend_mode // Was a switch-case, sorry for the mess.
			if ( _==4 ) {
				return 2;
			} else if ( _==2 ) {
				return 0;
			} else if ( _==3 ) {
				return 1;
			} else {
				return 3;
			};
		}

		public static UNKNOWN	BlendRGB( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	RGB1 = null;
			RGB1 = GlobalFuncs.ReadRGB( rgb1 );
			RGB2 = GlobalFuncs.ReadRGB( rgb2 );
			if ( RGB1.len < RGB2.len != null ) {
				RGB1 += 255;
			} else if ( RGB2.len < RGB1.len != null ) {
				RGB2 += 255;
			}
			usealpha = RGB1.len > 3;
			r = GlobalVars.undefined.round( RGB1[1] + ( RGB2[1] - RGB1[1] ) * amount, 1 );
			g = GlobalVars.undefined.round( RGB1[2] + ( RGB2[2] - RGB1[2] ) * amount, 1 );
			b = GlobalVars.undefined.round( RGB1[3] + ( RGB2[3] - RGB1[3] ) * amount, 1 );
			alpha = usealpha ? GlobalVars.undefined.round( RGB1[4] + ( RGB2[4] - RGB1[4] ) * amount, 1 ) : null;
			return GlobalVars.undefined( alpha ) ? GlobalVars.undefined( r, g, b ) : GlobalVars.undefined( r, g, b, alpha );
		}

		public static int	blood_incompatible( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	donor_antigen = null;
			if ( !donor || !receiver != null ) {
				return 0;
			}
			if ( donor_species && receiver_species != null ) {
				if ( donor_species != receiver_species != null ) {
					return 1;
				}
			}
			donor_antigen = GlobalVars.undefined( donor, 1, GlobalVars.undefined( donor ) );
			receiver_antigen = GlobalVars.undefined( receiver, 1, GlobalVars.undefined( receiver ) );
			donor_rh = GlobalVars.undefined( donor, "+", 1, null ) > 0;
			receiver_rh = GlobalVars.undefined( receiver, "+", 1, null ) > 0;
			if ( donor_rh && !receiver_rh != null ) {
				return 1;
			}
			local _ = receiver_antigen // Was a switch-case, sorry for the mess.
			if ( _=="A" ) {
				if ( donor_antigen != "A" && donor_antigen != "O" != null ) {
					return 1;
				}
			} else if ( _=="B" ) {
				if ( donor_antigen != "B" && donor_antigen != "O" != null ) {
					return 1;
				}
			} else if ( _=="O" ) {
				if ( donor_antigen != "O" != null ) {
					return 1;
				}
			};
			return 0;
		}

		public static UNKNOWN	blood_splatter( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	B = null;
			decal_type = Ent_Effect_Decal_Cleanable_Blood_Splatter;
			T = GlobalFuncs.get_turf( target );
			if ( source instanceof Mob_Living_Carbon_Human != null ) {
				M = source;
				source = M.get_blood( M.vessel );
			} else if ( source instanceof Mob_Living_Carbon_Monkey != null ) {
				donor = source;
				source = new Reagent_Blood();
				source.data.blood_DNA = donor.dna.unique_enzymes;
				source.data.blood_type = donor.dna.blood_type;
			}
			drips = new ByTable();
			drop = null;
			foreach (_ in T ) {
				drop = undefined;
				if ( !( drop instanceof Ent_Effect_Decal_Cleanable_Blood_Drip ) != null ) {
					continue;
				}
				drips = drips | drop.drips;
				GlobalFuncs.qdel( drop );
			};
			if ( !large && drips.len < 3 != null ) {
				decal_type = Ent_Effect_Decal_Cleanable_Blood_Drip;
			}
			B = GlobalVars.undefined( decal_type, T );
			if ( !B != null ) {
				B = decal_type( T );
			}
			drop = B;
			if ( drop instanceof Ent_Effect_Decal_Cleanable_Blood_Drip && drips && drips.len && !large != null ) {
				drop.overlays = drop.overlays | drips;
				drop.drips = drop.drips | drips;
			}
			if ( !source != null ) {
				return B;
			}
			if ( source.data.blood_DNA != null ) {
				B.blood_DNA = new ByTable();
				if ( source.data.blood_type != null ) {
					B.blood_DNA[source.data.blood_DNA] = source.data.blood_type;
				} else {
					B.blood_DNA[source.data.blood_DNA] = "O+";
				}
			}
			return B;
		}

		public static dynamic	Broadcast_Message( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	radios = null;
			message = GlobalVars.undefined( message, 1, 512 );
			if ( !message != null ) {
				return;
			}
			radios = new ByTable();
			virt = GlobalFuncs.PoolOrNew( BaseDynamic_Virtualspeaker, null );
			virt.name = name;
			virt.job = job;
			virt.languages = AM.languages;
			virt.source = AM;
			virt.radio = radio;
			virt.verb_say = verb_say;
			virt.verb_ask = verb_ask;
			virt.verb_exclaim = verb_exclaim;
			virt.verb_yell = verb_yell;
			if ( compression > 0 != null ) {
				message = GlobalFuncs.Gibberish( message, compression + 40 );
			}
			if ( data == 1 != null ) {
				R = null;
				foreach (_ in GlobalVars.all_radios["" + freq] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio_Intercom ) != null ) {
						continue;
					}
					if ( R.receive_range( freq, level ) > -1 != null ) {
						radios += R;
					}
				};
			} else if ( data == 2 != null ) {
				R = null;
				foreach (_ in GlobalVars.all_radios["" + freq] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					if ( R.subspace_transmission != null ) {
						continue;
					}
					if ( R.receive_range( freq, level ) > -1 != null ) {
						radios += R;
					}
				};
			} else if ( data == 5 != null ) {
				R = null;
				foreach (_ in GlobalVars.all_radios["" + freq] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					if ( !R.centcom != null ) {
						continue;
					}
					if ( R.receive_range( freq, level ) > -1 != null ) {
						radios += R;
					}
				};
			} else {
				R = null;
				foreach (_ in GlobalVars.all_radios["" + freq] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					if ( R.receive_range( freq, level ) > -1 != null ) {
						radios += R;
					}
				};
				freqtext = GlobalVars.undefined( freq );
				R = null;
				foreach (_ in GlobalVars.all_radios["" + GlobalVars.SYND_FREQ] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					if ( R.receive_range( GlobalVars.SYND_FREQ, new ByTable(new object [] {R.z}) ) > -1 && freqtext in GlobalVars.radiochannelsreverse != null ) {
						radios = radios | R;
					}
				};
			}
			receive = GlobalFuncs.get_mobs_in_radio_ranges( radios );
			R = null;
			foreach (_ in receive ) {
				R = undefined;
				if ( R.client && R.client.holder && !( R.client.prefs.chat_toggles & 32 ) != null ) {
					receive -= R;
				}
			};
			M = null;
			foreach (_ in GlobalVars.player_list ) {
				M = undefined;
				if ( M instanceof Mob_Dead_Observer && M.client && M.client.prefs.chat_toggles & 512 != null ) {
					receive = receive | M;
				}
			};
			rendered = virt.compose_message( virt, virt.languages, message, freq, spans );
			hearer = null;
			foreach (_ in receive ) {
				hearer = undefined;
				if ( !( hearer instanceof BaseDynamic ) != null ) {
					continue;
				}
				hearer.Hear( rendered, virt, AM.languages, message, freq, spans );
			};
			if ( GlobalVars.undefined( receive ) != null ) {
				blackbox_msg = "" + AM + " " + AM.say_quote( message, spans );
				if ( GlobalVars.blackbox instanceof Ent_Machinery_BlackboxRecorder != null ) {
					local _ = freq // Was a switch-case, sorry for the mess.
					if ( _==1459 ) {
						GlobalVars.blackbox.msg_common += blackbox_msg;
					} else if ( _==1351 ) {
						GlobalVars.blackbox.msg_science += blackbox_msg;
					} else if ( _==1353 ) {
						GlobalVars.blackbox.msg_command += blackbox_msg;
					} else if ( _==1355 ) {
						GlobalVars.blackbox.msg_medical += blackbox_msg;
					} else if ( _==1357 ) {
						GlobalVars.blackbox.msg_engineering += blackbox_msg;
					} else if ( _==1359 ) {
						GlobalVars.blackbox.msg_security += blackbox_msg;
					} else if ( _==1441 ) {
						GlobalVars.blackbox.msg_deathsquad += blackbox_msg;
					} else if ( _==1213 ) {
						GlobalVars.blackbox.msg_syndicate += blackbox_msg;
					} else if ( _==1349 ) {
						GlobalVars.blackbox.msg_service += blackbox_msg;
					} else if ( _==1347 ) {
						GlobalVars.blackbox.msg_cargo += blackbox_msg;
					} else {
						GlobalVars.blackbox.messages += blackbox_msg;
					};
				}
			}
			::thread.schedule( 50, function() {
				GlobalFuncs.qdel( virt );
				return;
			});
		}

		public static dynamic	Broadcast_SimpleMessage( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			Mob_Living_Carbon_Human	H = null;
			if ( !M != null ) {
				H = new Mob_Living_Carbon_Human();
				M = H;
			}
			connection = GlobalVars.radio_controller.return_frequency( frequency );
			display_freq = connection.frequency;
			receive = new ByTable();
			if ( data == 1 != null ) {
				R = null;
				foreach (_ in connection.devices["" + GlobalVars.RADIO_CHAT] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio_Intercom ) != null ) {
						continue;
					}
					position = GlobalFuncs.get_turf( R );
					if ( position && position.z == level != null ) {
						receive = receive | R.send_hear( display_freq, level );
					}
				};
			} else if ( data == 2 != null ) {
				R = null;
				foreach (_ in connection.devices["" + GlobalVars.RADIO_CHAT] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					if ( R.subspace_transmission != null ) {
						continue;
					}
					position = GlobalFuncs.get_turf( R );
					if ( position && position.z == level != null ) {
						receive = receive | R.send_hear( display_freq );
					}
				};
			} else if ( data == 3 != null ) {
				syndicateconnection = GlobalVars.radio_controller.return_frequency( GlobalVars.SYND_FREQ );
				R = null;
				foreach (_ in syndicateconnection.devices["" + GlobalVars.RADIO_CHAT] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					position = GlobalFuncs.get_turf( R );
					if ( position && position.z == level != null ) {
						receive = receive | R.send_hear( GlobalVars.SYND_FREQ );
					}
				};
			} else if ( data == 5 != null ) {
				R = null;
				foreach (_ in GlobalVars.all_radios["" + GlobalVars.RADIO_CHAT] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					if ( R.centcom != null ) {
						receive = receive | R.$send hear( GlobalVars.CENTCOM_FREQ );
					}
				};
			} else {
				R = null;
				foreach (_ in connection.devices["" + GlobalVars.RADIO_CHAT] ) {
					R = undefined;
					if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
						continue;
					}
					position = GlobalFuncs.get_turf( R );
					if ( position && position.z == level != null ) {
						receive = receive | R.send_hear( display_freq );
					}
				};
			}
			heard_normal = new ByTable();
			heard_garbled = new ByTable();
			heard_gibberish = new ByTable();
			R = null;
			foreach (_ in receive ) {
				R = undefined;
				if ( R.client && !( R.client.prefs.chat_toggles & 32 ) != null ) {
					continue;
				}
				if ( compression > 0 != null ) {
					heard_gibberish += R;
					continue;
				}
				if ( R.languages & M.languages != null ) {
					heard_normal += R;
				} else {
					heard_garbled += R;
				}
			};
			if ( GlobalVars.undefined( heard_normal ) || GlobalVars.undefined( heard_garbled ) || GlobalVars.undefined( heard_gibberish ) != null ) {
				part_a = "<span class='radio'><span class='name'>";
				freq_text = null;
				local _ = display_freq // Was a switch-case, sorry for the mess.
				if ( _==1213 ) {
					freq_text = "#unkn";
				} else if ( _==1353 ) {
					freq_text = "Command";
				} else if ( _==1351 ) {
					freq_text = "Science";
				} else if ( _==1355 ) {
					freq_text = "Medical";
				} else if ( _==1357 ) {
					freq_text = "Engineering";
				} else if ( _==1359 ) {
					freq_text = "Security";
				} else if ( _==1349 ) {
					freq_text = "Service";
				} else if ( _==1347 ) {
					freq_text = "Supply";
				} else if ( _==1447 ) {
					freq_text = "AI Private";
				};
				if ( !freq_text != null ) {
					freq_text = GlobalFuncs.format_frequency( display_freq );
				}
				part_b_extra = "";
				if ( data == 3 != null ) {
					part_b_extra = " <i>(Intercepted)</i>";
				}
				radio = new Ent_Item_Device_Radio_Headset();
				part_b = GlobalVars.undefined( "</span><b> " ).icon( radio ).str( "[" ).item( freq_text ).str( "]" ).item( part_b_extra ).str( "</b> <span class='message'>" );
				part_c = "</span></span>";
				if ( display_freq == GlobalVars.SYND_FREQ != null ) {
					part_a = "<span class='syndradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.COMM_FREQ != null ) {
					part_a = "<span class='comradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.SCI_FREQ != null ) {
					part_a = "<span class='sciradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.MED_FREQ != null ) {
					part_a = "<span class='medradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.ENG_FREQ != null ) {
					part_a = "<span class='engradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.SEC_FREQ != null ) {
					part_a = "<span class='secradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.SERV_FREQ != null ) {
					part_a = "<span class='servradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.SUPP_FREQ != null ) {
					part_a = "<span class='suppradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.CENTCOM_FREQ != null ) {
					part_a = "<span class='centcomradio'><span class='name'>";
				} else if ( display_freq == GlobalVars.AIPRIV_FREQ != null ) {
					part_a = "<span class='aiprivradio'><span class='name'>";
				}
				part_blackbox_b = "</span><b> [" + freq_text + "]</b> <span class='message'>";
				blackbox_msg = "" + part_a + source + part_blackbox_b + "\"" + text + "\"" + part_c;
				if ( GlobalVars.blackbox instanceof Ent_Machinery_BlackboxRecorder != null ) {
					local _ = display_freq // Was a switch-case, sorry for the mess.
					if ( _==1459 ) {
						GlobalVars.blackbox.msg_common += blackbox_msg;
					} else if ( _==1351 ) {
						GlobalVars.blackbox.msg_science += blackbox_msg;
					} else if ( _==1353 ) {
						GlobalVars.blackbox.msg_command += blackbox_msg;
					} else if ( _==1355 ) {
						GlobalVars.blackbox.msg_medical += blackbox_msg;
					} else if ( _==1357 ) {
						GlobalVars.blackbox.msg_engineering += blackbox_msg;
					} else if ( _==1359 ) {
						GlobalVars.blackbox.msg_security += blackbox_msg;
					} else if ( _==1441 ) {
						GlobalVars.blackbox.msg_deathsquad += blackbox_msg;
					} else if ( _==1213 ) {
						GlobalVars.blackbox.msg_syndicate += blackbox_msg;
					} else if ( _==1349 ) {
						GlobalVars.blackbox.msg_service += blackbox_msg;
					} else if ( _==1347 ) {
						GlobalVars.blackbox.msg_cargo += blackbox_msg;
					} else {
						GlobalVars.blackbox.messages += blackbox_msg;
					};
				}
				if ( GlobalVars.undefined( heard_normal ) != null ) {
					rendered = "" + part_a + source + part_b + "\"" + text + "\"" + part_c;
					R = null;
					foreach (_ in heard_normal ) {
						R = undefined;
						R.show_message( rendered, 2 );
					};
				}
				if ( GlobalVars.undefined( heard_garbled ) != null ) {
					quotedmsg = "\"" + GlobalFuncs.stars( text ) + "\"";
					rendered = "" + part_a + source + part_b + quotedmsg + part_c;
					R = null;
					foreach (_ in heard_garbled ) {
						R = undefined;
						R.show_message( rendered, 2 );
					};
				}
				if ( GlobalVars.undefined( heard_gibberish ) != null ) {
					quotedmsg = "\"" + GlobalFuncs.Gibberish( text, compression + 50 ) + "\"";
					rendered = "" + part_a + GlobalFuncs.Gibberish( source, compression + 50 ) + part_b + quotedmsg + part_c;
					R = null;
					foreach (_ in heard_gibberish ) {
						R = undefined;
						R.show_message( rendered, 2 );
					};
				}
			}
		}

		public static dynamic	build_click( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	holder = null;
			holder = null;
			H = null;
			foreach (_ in Game ) {
				H = undefined;
				if ( !( H instanceof Ent_Effect_Bmode_Buildholder ) != null ) {
					continue;
				}
				if ( H.cl == user.client != null ) {
					holder = H;
					break;
				}
			};
			if ( !holder != null ) {
				return;
			}
			pa = GlobalVars.undefined( _params );
			if ( _object instanceof Ent_Effect_Bmode != null ) {
				return;
			}
			local _ = buildmode // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				if ( _object instanceof Tile && pa.Find( "left" ) && !pa.$Find( "alt" ) && !pa.$Find( "ctrl" ) != null ) {
					T = _object;
					if ( _object instanceof Tile_Space != null ) {
						T.ChangeTurf( Tile_Simulated_Floor_Plasteel );
					} else if ( _object instanceof Tile_Simulated_Floor != null ) {
						T.ChangeTurf( Tile_Simulated_Wall );
					} else if ( _object instanceof Tile_Simulated_Wall != null ) {
						T.ChangeTurf( Tile_Simulated_Wall_RWall );
					}
					GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " built " + T + " at (" + T.x + "," + T.y + "," + T.z + ")" );
					return;
				} else if ( pa.Find( "right" ) != null ) {
					GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " deleted " + _object + " at (" + _object.x + "," + _object.y + "," + _object.z + ")" );
					if ( _object instanceof Tile_Simulated_Wall != null ) {
						T = _object;
						T.ChangeTurf( Tile_Simulated_Floor_Plasteel );
					} else if ( _object instanceof Tile_Simulated_Floor != null ) {
						T = _object;
						T.ChangeTurf( Tile_Space );
					} else if ( _object instanceof Tile_Simulated_Wall_RWall != null ) {
						T = _object;
						T.ChangeTurf( Tile_Simulated_Wall );
					} else if ( _object instanceof Entity != null ) {
						GlobalFuncs.qdel( _object );
					}
					return;
				} else if ( _object instanceof Tile && T.$Find( "alt" ) && T.$Find( "left" ) != null ) {
					GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " built an airlock at (" + _object.x + "," + _object.y + "," + _object.z + ")" );
					new Ent_Machinery_Door_Airlock( GlobalFuncs.get_turf( _object ) );
				} else if ( _object instanceof Tile && pa.Find( "ctrl" ) && pa.$Find( "left" ) != null ) {
					local _ = holder.builddir.dir // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						WIN = new Ent_Structure_Window_Reinforced( GlobalFuncs.get_turf( _object ) );
						WIN.dir = GlobalVars.NORTH;
					} else if ( _==2 ) {
						WIN = new Ent_Structure_Window_Reinforced( GlobalFuncs.get_turf( _object ) );
						WIN.dir = GlobalVars.SOUTH;
					} else if ( _==4 ) {
						WIN = new Ent_Structure_Window_Reinforced( GlobalFuncs.get_turf( _object ) );
						WIN.dir = GlobalVars.EAST;
					} else if ( _==8 ) {
						WIN = new Ent_Structure_Window_Reinforced( GlobalFuncs.get_turf( _object ) );
						WIN.dir = GlobalVars.WEST;
					} else if ( _==9 ) {
						WIN = new Ent_Structure_Window_Reinforced( GlobalFuncs.get_turf( _object ) );
						WIN.dir = GlobalVars.NORTHWEST;
					};
					GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " built a window at (" + _object.x + "," + _object.y + "," + _object.z + ")" );
				}
			} else if ( _==2 ) {
				if ( pa.Find( "left" ) != null ) {
					if ( GlobalVars.undefined( holder.buildmode.objholder, Tile ) != null ) {
						T = GlobalFuncs.get_turf( _object );
						GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " modified " + T + " (" + T.x + "," + T.y + "," + T.z + ") to " + holder.buildmode.objholder );
						T.ChangeTurf( holder.buildmode.objholder );
					} else {
						A = T.objholder( GlobalFuncs.get_turf( _object ) );
						A.dir = holder.builddir.dir;
						GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " modified " + A + "'s (" + A.x + "," + A.y + "," + A.z + ") dir to " + holder.builddir.dir );
					}
				} else if ( holder.$Find( "right" ) != null ) {
					if ( GlobalVars.undefined( _object ) != null ) {
						GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " deleted " + _object + " at (" + _object.x + "," + _object.y + "," + _object.z + ")" );
						GlobalFuncs.qdel( _object );
					}
				}
			} else if ( _==3 ) {
				if ( pa.Find( "left" ) != null ) {
					if ( _object.vars.Find( holder.buildmode.varholder ) != null ) {
						GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " modified " + _object.name + "'s " + holder.buildmode.varholder + " to " + holder.valueholder );
						_object.vars[holder.buildmode.varholder] = holder.buildmode.valueholder;
					} else {
						GlobalVars.undefined.user.write( "<span class='warning'>" + GlobalVars.undefined( _object.name ) + " does not have a var called '" + holder.buildmode.varholder + "'</span>" );
					}
				}
				if ( pa.Find( "right" ) != null ) {
					if ( _object.vars.Find( holder.buildmode.varholder ) != null ) {
						GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " modified " + _object.name + "'s " + holder.buildmode.varholder + " to " + holder.valueholder );
						_object.vars[holder.buildmode.varholder] = GlobalVars.undefined( _object.vars[holder.buildmode.varholder] );
					} else {
						GlobalVars.undefined.user.write( "<span class='warning'>" + GlobalVars.undefined( _object.name ) + " does not have a var called '" + holder.buildmode.varholder + "'</span>" );
					}
				}
			} else if ( _==4 ) {
				if ( pa.Find( "left" ) != null ) {
					if ( GlobalVars.undefined( _object ) != null ) {
						return;
					}
					holder.throw_atom = _object;
				}
				if ( pa.Find( "right" ) != null ) {
					if ( holder.throw_atom != null ) {
						holder.throw_atom.throw_at( _object, 10, 1, user );
						GlobalFuncs.log_admin( "Build Mode: " + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " threw " + holder.throw_atom + " at " + _object + " (" + _object.x + "," + _object.y + "," + _object.z + ")" );
					}
				}
			} else if ( _==5 ) {
				if ( !holder.cornerA != null ) {
					holder.cornerA = GlobalFuncs.get_turf( _object );
					return;
				}
				if ( holder.cornerA && !holder.cornerB != null ) {
					holder.cornerB = GlobalFuncs.get_turf( _object );
				}
				if ( pa.Find( "left" ) != null ) {
					if ( holder.cornerA && holder.cornerB != null ) {
						if ( !holder.generator_path != null ) {
							GlobalVars.undefined.user.write( "<span class='warning'>Select generator type first.</span>" );
						}
						G = holder.generator_path();
						G.defineRegion( holder.cornerA, holder.cornerB, 1 );
						G.$generate();
						holder.cornerA = null;
						holder.cornerB = null;
						return;
					}
				}
				holder.cornerA = null;
				holder.cornerB = null;
			};
		}

		public static UNKNOWN	calculate_adjacencies( UNKNOWN [object Object] =null ) {
			UNKNOWN	adjacencies = null;
			if ( !A.loc != null ) {
				return 0;
			}
			adjacencies = 0;
			if ( A.can_be_unanchored != null ) {
				AM = A;
				if ( !AM.anchored != null ) {
					return 0;
				}
				direction = null;
				foreach (_ in GlobalVars.alldirs ) {
					direction = undefined;
					AM = GlobalFuncs.find_type_in_direction( A, direction );
					if ( AM instanceof BaseDynamic != null ) {
						if ( AM.anchored != null ) {
							adjacencies = adjacencies | GlobalFuncs.transform_dir( direction );
						}
					} else if ( AM != null ) {
						adjacencies = adjacencies | GlobalFuncs.transform_dir( direction );
					}
				};
			} else {
				direction = null;
				foreach (_ in GlobalVars.alldirs ) {
					direction = undefined;
					if ( GlobalFuncs.find_type_in_direction( A, direction ) != null ) {
						adjacencies = adjacencies | GlobalFuncs.transform_dir( direction );
					}
				};
			}
			return adjacencies;
		}

		public static UNKNOWN	CallMaterialName( UNKNOWN [object Object] =null ) {
			UNKNOWN	temp_reagent = null;
			return_name = null;
			if ( GlobalVars.undefined( ID, 1, 2 ) == "$" != null ) {
				return_name = GlobalVars.undefined( ID, 2, null );
				local _ = return_name // Was a switch-case, sorry for the mess.
				if ( _=="metal" ) {
					return_name = "Metal";
				} else if ( _=="glass" ) {
					return_name = "Glass";
				} else if ( _=="gold" ) {
					return_name = "Gold";
				} else if ( _=="silver" ) {
					return_name = "Silver";
				} else if ( _=="plasma" ) {
					return_name = "Solid Plasma";
				} else if ( _=="uranium" ) {
					return_name = "Uranium";
				} else if ( _=="diamond" ) {
					return_name = "Diamond";
				} else if ( _=="clown" ) {
					return_name = "Bananium";
				};
			} else {
				R = null;
				foreach (_ in GlobalVars.undefined( Reagent ) - Reagent ) {
					R = undefined;
					temp_reagent = null;
					temp_reagent = R();
					if ( temp_reagent.id == ID != null ) {
						return_name = temp_reagent.name;
						GlobalFuncs.qdel( temp_reagent );
						temp_reagent = null;
						break;
					}
				};
			}
			return return_name;
		}

		public static UNKNOWN	CallTechName( UNKNOWN [object Object] =null ) {
			UNKNOWN	check_tech = null;
			return_name = null;
			T = null;
			foreach (_ in GlobalVars.undefined( Tech ) - Tech ) {
				T = undefined;
				check_tech = null;
				check_tech = T();
				if ( check_tech.id == ID != null ) {
					return_name = check_tech.name;
					GlobalFuncs.qdel( check_tech );
					check_tech = null;
					break;
				}
			};
			return return_name;
		}

		public static dynamic	camera_sort( UNKNOWN [object Object] =null ) {
			UNKNOWN	a = null;
			i = null;
			i = L.len;
			while (i > 0) {
				j = null;
				foreach (_ in GlobalVars.undefined( 1, i - 1 ) ) {
					j = undefined;
					a = L[j];
					b = L[j + 1];
					if ( a.c_tag_order != b.c_tag_order != null ) {
						if ( a.c_tag_order > b.c_tag_order != null ) {
							L.Swap( j, j + 1 );
						}
					} else if ( GlobalVars.undefined( a.c_tag, b.c_tag ) < 0 != null ) {
						L.Swap( j, j + 1 );
					}
				};
				i--;
			};
			return L;
		}

		public static int	can_embed( UNKNOWN [object Object] =null ) {
			ByTable	embed_items = null;
			if ( W.is_sharp() != null ) {
				return 1;
			}
			if ( GlobalFuncs.is_pointed( W ) != null ) {
				return 1;
			}
			embed_items = new ByTable(new object [] {Ent_Item_Stack_Rods});
			if ( GlobalFuncs.is_type_in_list( W, embed_items ) != null ) {
				return 1;
			}
		}

		public static int	can_see( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	current = null;
			if ( length == null != null ) {
				length = 5;
			}
			current = GlobalFuncs.get_turf( source );
			target_turf = GlobalFuncs.get_turf( target );
			steps = 0;
			while (current != target_turf) {
				if ( steps > length != null ) {
					return 0;
				}
				if ( current.opacity != null ) {
					return 0;
				}
				A = null;
				foreach (_ in current ) {
					A = undefined;
					if ( !( A instanceof BaseStatic ) != null ) {
						continue;
					}
					if ( A.opacity != null ) {
						return 0;
					}
				};
				current = GlobalVars.undefined( current, target_turf );
				steps++;
			};
			return 1;
		}

		public static dynamic	cancel_progress_bar( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( user && user.client && progbar != null ) {
				user.client.images -= progbar;
			}
		}

		public static int	CanHug( UNKNOWN [object Object] =null ) {
			dynamic	C = null;
			if ( !( M instanceof Mob_Living ) != null ) {
				return 0;
			}
			if ( M.stat == 2 != null ) {
				return 0;
			}
			if ( M.getorgan( Ent_Item_Organ_Internal_Alien_Hivenode ) != null ) {
				return 0;
			}
			if ( M instanceof Mob_Living_SimpleAnimal_Pet_Dog_Corgi || M instanceof Mob_Living_Carbon_Monkey != null ) {
				return 1;
			}
			C = M;
			if ( C instanceof Mob_Living_Carbon_Human != null ) {
				H = C;
				if ( H.is_mouth_covered.lcall( new ByTable().set( "head_only", 1 ) ) != null ) {
					return 0;
				}
				return 1;
			}
			return 0;
		}

		public static UNKNOWN	capitalize( UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( GlobalVars.undefined( t, 1, 2 ) ) + GlobalVars.undefined( t, 2, null );
		}

		public static ByTable	cardinalrange( UNKNOWN [object Object] =null ) {
			ByTable	things = null;
			things = new ByTable();
			direction = null;
			foreach (_ in GlobalVars.cardinal ) {
				direction = undefined;
				T = GlobalVars.undefined( center, direction );
				if ( !T != null ) {
					continue;
				}
				things += T.contents;
			};
			return things;
		}

		public static UNKNOWN	Ceiling( UNKNOWN [object Object] =null ) {
			return -GlobalVars.undefined.round( -x );
		}

		public static dynamic	Centcomm_announce( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	msg = null;
			msg = GlobalVars.undefined( GlobalFuncs.sanitize( text ), 1, 1024 );
			msg = GlobalVars.undefined( "<span class='adminnotice'><b><font color=orange>CENTCOM:</font>" ).item( GlobalFuncs.key_name_admin( Sender ) ).str( " (<A HREF='?_src_=holder;adminmoreinfo=" ).ref( Sender ).str( "'>?</A>) (<A HREF='?_src_=holder;adminplayeropts=" ).ref( Sender ).str( "'>PP</A>) (<A HREF='?_src_=vars;Vars=" ).ref( Sender ).str( "'>VV</A>) (<A HREF='?_src_=holder;subtlemessage=" ).ref( Sender ).str( "'>SM</A>) (<A HREF='?_src_=holder;adminplayerobservefollow=" ).ref( Sender ).str( "'>FLW</A>) (<A HREF='?_src_=holder;traitor=" ).ref( Sender ).str( "'>TP</A>) (<A HREF='?_src_=holder;BlueSpaceArtillery=" ).ref( Sender ).str( "'>BSA</A>) (<A HREF='?_src_=holder;CentcommReply=" ).ref( Sender ).str( "'>RPLY</A>):</b> " ).item( msg ).str( "</span>" );
			GlobalVars.admins.write( msg );
		}

		public static dynamic	center_image( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	x_offset = null;
			if ( x_dimension == null != null ) {
				x_dimension = 0;
			}
			if ( y_dimension == null != null ) {
				y_dimension = 0;
			}
			if ( !I != null ) {
				return;
			}
			if ( !x_dimension || !y_dimension != null ) {
				return;
			}
			if ( x_dimension == Game.icon_size && y_dimension == Game.icon_size != null ) {
				return I;
			}
			x_offset = -( x_dimension / Game.icon_size - 1 ) * Game.icon_size * 0.5;
			y_offset = -( y_dimension / Game.icon_size - 1 ) * Game.icon_size * 0.5;
			if ( x_dimension < Game.icon_size != null ) {
				x_offset *= -1;
			}
			if ( y_dimension < Game.icon_size != null ) {
				y_offset *= -1;
			}
			I.pixel_x = x_offset;
			I.pixel_y = y_offset;
			return I;
		}

		public static dynamic	changeling_transform( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	chosen_dna = null;
			chosen_dna = chosen_prof.dna;
			user.real_name = chosen_prof.name;
			user.underwear = chosen_prof.underwear;
			user.undershirt = chosen_prof.undershirt;
			user.socks = chosen_prof.socks;
			chosen_dna.transfer_identity( user, 1 );
			user.updateappearance.lcall( new ByTable().set( "mutcolor_update", 1 ) );
			user.update_body();
			user.$domutcheck();
			slot = null;
			foreach (_ in GlobalVars.slots ) {
				slot = undefined;
				if ( user.vars[slot] instanceof GlobalVars.slot2type[slot] && !chosen_prof.exists_list[slot] != null ) {
					GlobalFuncs.qdel( user.vars[slot] );
					continue;
				}
				if ( user.vars[slot] && !( user.vars[slot] instanceof GlobalVars.slot2type[slot] ) || !chosen_prof.exists_list[slot] != null ) {
					continue;
				}
				C = null;
				equip = 0;
				if ( !user.vars[slot] != null ) {
					thetype = GlobalVars.slot2type[slot];
					equip = 1;
					C = thetype( user );
				} else if ( user.vars[slot] instanceof GlobalVars.slot2type[slot] != null ) {
					C = user.vars[slot];
				}
				C.appearance = chosen_prof.appearance_list[slot];
				C.name = chosen_prof.name_list[slot];
				C.flags_cover = chosen_prof.flags_cover_list[slot];
				C.item_color = chosen_prof.item_color_list[slot];
				C.item_state = chosen_prof.item_state_list[slot];
				if ( equip != null ) {
					user.equip_to_slot_or_del( C, GlobalVars.slot2slot[slot] );
				}
			};
			user.regenerate_icons();
		}

		public static dynamic	changemap( UNKNOWN [object Object] =null ) {
			UNKNOWN	file = null;
			UNKNOWN _default;
			return;
			if ( !( VM instanceof Votablemap ) != null ) {
				return;
			}
			GlobalFuncs.log_game( "Changing map to " + VM.name + "(" + VM.friendlyname + ")" );
			file = File( "setnewmap.bat" );
			file.write( "\nset MAPROTATE=" + VM.name + "\n" );
			undefined = GlobalVars.undefined( "..\\bin\\maprotate.bat" );
			local _ = undefined // Was a switch-case, sorry for the mess.
			if ( _==null ) {
				GlobalFuncs.message_admins( "Failed to change map: Could not run map rotator" );
				GlobalFuncs.log_game( "Failed to change map: Could not run map rotator" );
			} else if ( _==0 ) {
				GlobalFuncs.log_game( "Changed to map " + VM.friendlyname );
				GlobalVars.nextmap = VM;
			} else if ( _==11 ) {
				GlobalFuncs.message_admins( "Failed to change map: File error: Map rotator script couldn't find file listing new map" );
				GlobalFuncs.log_game( "Failed to change map: File error: Map rotator script couldn't find file listing new map" );
			} else if ( _==12 ) {
				GlobalFuncs.message_admins( "Failed to change map: File error: Map rotator script couldn't find tgstation-server framework" );
				GlobalFuncs.log_game( "Failed to change map: File error: Map rotator script couldn't find tgstation-server framework" );
			} else if ( _==21 ) {
				GlobalFuncs.message_admins( "Failed to change map: Conflicting operation error: Current server update operation detected" );
				GlobalFuncs.log_game( "Failed to change map: Conflicting operation error: Current server update operation detected" );
			} else if ( _==22 ) {
				GlobalFuncs.message_admins( "Failed to change map: Conflicting operation error: Current map rotation operation detected" );
				GlobalFuncs.log_game( "Failed to change map: Conflicting operation error: Current map rotation operation detected" );
			} else if ( _==31 ) {
				GlobalFuncs.message_admins( "Failed to change map: External error: Could not compile new map:" + VM.name );
				GlobalFuncs.log_game( "Failed to change map: External error: Could not compile new map:" + VM.name );
			} else {
				GlobalFuncs.message_admins( "Failed to change map: Unknown error: Error code #" + undefined );
				GlobalFuncs.log_game( "Failed to change map: Unknown error: Error code #" + undefined );
			};
			return _default;
		}

		public static UNKNOWN	cheap_hypotenuse( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined.sqrt( GlobalVars.undefined( GlobalVars.undefined.abs( Ax - Bx ), 2 ) + GlobalVars.undefined( GlobalVars.undefined.abs( Ay - By ), 2 ) );
		}

		public static UNKNOWN	check_if_greater_rights_than( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.undefined.user && GlobalVars.undefined.user.client != null ) {
				if ( GlobalVars.undefined.user.client.holder != null ) {
					if ( !other || !other.holder != null ) {
						return 1;
					}
					return GlobalVars.undefined.user.client.holder.check_if_greater_rights_than_holder( other.holder );
				}
			}
			return 0;
		}

		public static int	check_rights( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( show_msg == null != null ) {
				show_msg = 1;
			}
			if ( GlobalVars.undefined.user && GlobalVars.undefined.user.client != null ) {
				if ( GlobalFuncs.check_rights_for( GlobalVars.undefined.user.client, rights_required ) != null ) {
					return 1;
				} else if ( show_msg != null ) {
					GlobalVars.undefined.user.write( "<font color='red'>Error: You do not have sufficient rights to do that. You require one of the following flags:" + GlobalFuncs.rights2text( rights_required, " " ) + ".</font>" );
				}
			}
			return 0;
		}

		public static int	check_rights_for( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( subject && subject.holder && subject.holder.rank != null ) {
				if ( rights_required && !( rights_required & subject.holder.rank.rights ) != null ) {
					return 0;
				}
				return 1;
			}
			return 0;
		}

		public static int	check_tank_exists( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( !parent_tank || !( parent_tank instanceof Ent_Item_Weapon_Watertank ) != null ) {
				M.unEquip( O );
				GlobalFuncs.qdel( 0 );
				return 0;
			} else {
				return 1;
			}
		}

		public static string	check_zone( UNKNOWN [object Object] =null ) {
			if ( !zone != null ) {
				return "chest";
			}
			local _ = zone // Was a switch-case, sorry for the mess.
			if ( _=="eyes" ) {
				zone = "head";
			} else if ( _=="mouth" ) {
				zone = "head";
			} else if ( _=="l_hand" ) {
				zone = "l_arm";
			} else if ( _=="r_hand" ) {
				zone = "r_arm";
			} else if ( _=="l_foot" ) {
				zone = "l_leg";
			} else if ( _=="r_foot" ) {
				zone = "r_leg";
			} else if ( _=="groin" ) {
				zone = "chest";
			};
			return zone;
		}

		public static dynamic	chemscan( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	H = null;
			if ( M instanceof Mob_Living_Carbon_Human != null ) {
				H = M;
				if ( H.reagents != null ) {
					if ( H.reagents.reagent_list.len != null ) {
						user.write( "<span class='notice'>Subject contains the following reagents:</span>" );
						R = null;
						foreach (_ in H.reagents.reagent_list ) {
							R = undefined;
							if ( !( R instanceof Reagent ) != null ) {
								continue;
							}
							user.write( "<span class='notice'>" + R.volume + " units of " + R.name + ( R.overdosed == 1 ? "</span> - <span class='boldannounce'>OVERDOSING</span>" : ".</span>" ) );
						};
					} else {
						user.write( "<span class='notice'>Subject contains no reagents.</span>" );
					}
					if ( H.reagents.addiction_list.len != null ) {
						user.write( "<span class='boldannounce'>Subject is addicted to the following reagents:</span>" );
						R = null;
						foreach (_ in H.reagents.addiction_list ) {
							R = undefined;
							if ( !( R instanceof Reagent ) != null ) {
								continue;
							}
							user.write( "<span class='danger'>" + R.name + "</span>" );
						};
					} else {
						user.write( "<span class='notice'>Subject is not addicted to any reagents.</span>" );
					}
				}
			}
		}

		public static UNKNOWN	circlerange( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	centerturf = null;
			if ( center == null != null ) {
				center = GlobalVars.undefined.user;
			}
			if ( radius == null != null ) {
				radius = 3;
			}
			centerturf = GlobalFuncs.get_turf( center );
			turfs = new List();
			rsq = radius * ( radius + 0.5 );
			T = null;
			foreach (_ in GlobalVars.undefined( radius, centerturf ) ) {
				T = undefined;
				if ( !( T instanceof BaseStatic ) != null ) {
					continue;
				}
				dx = T.x - centerturf.x;
				dy = T.y - centerturf.y;
				if ( dx * dx + dy * dy <= rsq != null ) {
					turfs += T;
				}
			};
			return turfs;
		}

		public static UNKNOWN	circlerangeturfs( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	centerturf = null;
			if ( center == null != null ) {
				center = GlobalVars.undefined.user;
			}
			if ( radius == null != null ) {
				radius = 3;
			}
			centerturf = GlobalFuncs.get_turf( center );
			turfs = new List();
			rsq = radius * ( radius + 0.5 );
			T = null;
			foreach (_ in GlobalVars.undefined( radius, centerturf ) ) {
				T = undefined;
				dx = T.x - centerturf.x;
				dy = T.y - centerturf.y;
				if ( dx * dx + dy * dy <= rsq != null ) {
					turfs += T;
				}
			};
			return turfs;
		}

		public static UNKNOWN	Clamp( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined.max( min, GlobalVars.undefined.min( val, max ) );
		}

		public static dynamic	clearlist( UNKNOWN [object Object] =null ) {
			if ( list instanceof new List != null ) {
				list.len = 0;
			}
			return;
		}

		public static dynamic	closeToolTip( UNKNOWN [object Object] =null ) {
			if ( user instanceof Mob != null ) {
				if ( user.client && user.client.tooltips != null ) {
					user.client.tooltips.f_hide();
				}
			}
		}

		public static dynamic	cmd_admin_mute( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			string	muteunmute = null;
			if ( automute == null != null ) {
				automute = 0;
			}
			if ( !whom != null ) {
				return;
			}
			local _ = mute_type // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				mute_string = "IC (say and emote)";
			} else if ( _==2 ) {
				mute_string = "OOC";
			} else if ( _==4 ) {
				mute_string = "pray";
			} else if ( _==8 ) {
				mute_string = "adminhelp, admin PM and ASAY";
			} else if ( _==16 ) {
				mute_string = "deadchat and DSAY";
			} else if ( _==31 ) {
				mute_string = "everything";
			} else {
				return;
			};
			C = null;
			if ( whom instanceof BAD_GOOFY_EXPANSION??? != null ) {
				C = whom;
			} else if ( GlobalVars.undefined( whom ) != null ) {
				C = GlobalVars.directory[whom];
			} else {
				return;
			}
			P = null;
			if ( C != null ) {
				P = C.prefs;
			} else {
				P = GlobalVars.preferences_datums[whom];
			}
			if ( !P != null ) {
				return;
			}
			if ( automute != null ) {
				if ( !GlobalVars.config.automute_on != null ) {
					return;
				}
			} else if ( !GlobalFuncs.check_rights() != null ) {
				return;
			}
			if ( automute != null ) {
				muteunmute = "auto-muted";
				P.muted = P.muted | mute_type;
				GlobalFuncs.log_admin( "SPAM AUTOMUTE: " + muteunmute + " " + GlobalFuncs.key_name( whom ) + " from " + mute_string );
				GlobalFuncs.message_admins( "SPAM AUTOMUTE: " + muteunmute + " " + GlobalFuncs.key_name_admin( whom ) + " from " + mute_string + "." );
				if ( C != null ) {
					C.write( "You have been " + muteunmute + " from " + mute_string + " by the SPAM AUTOMUTE system. Contact an admin." );
				}
				GlobalFuncs.feedback_add_details( "admin_verb", "AUTOMUTE" );
				return;
			}
			if ( P.muted & mute_type != null ) {
				muteunmute = "unmuted";
				P.muted = P.muted & ~mute_type;
			} else {
				muteunmute = "muted";
				P.muted = P.muted | mute_type;
			}
			GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has " + muteunmute + " " + GlobalFuncs.key_name( whom ) + " from " + mute_string );
			GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " has " + muteunmute + " " + GlobalFuncs.key_name_admin( whom ) + " from " + mute_string + "." );
			if ( C != null ) {
				C.write( "You have been " + muteunmute + " from " + mute_string + "." );
			}
			GlobalFuncs.feedback_add_details( "admin_verb", "MUTE" );
		}

		public static UNKNOWN	cmp_abilities_cost( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return b.plasma_cost - a.plasma_cost;
		}

		public static UNKNOWN	cmp_ckey_asc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( b.ckey, a.ckey );
		}

		public static UNKNOWN	cmp_ckey_dsc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( a.ckey, b.ckey );
		}

		public static UNKNOWN	cmp_name_asc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( b.name, a.name );
		}

		public static UNKNOWN	cmp_name_dsc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( a.name, b.name );
		}

		public static UNKNOWN	cmp_numeric_asc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return a - b;
		}

		public static UNKNOWN	cmp_records_asc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( b.fields[GlobalVars.cmp_field], a.fields[GlobalVars.cmp_field] );
		}

		public static UNKNOWN	cmp_records_dsc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( a.fields[GlobalVars.cmp_field], b.fields[GlobalVars.cmp_field] );
		}

		public static UNKNOWN	cmp_rped_sort( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return B.rating - A.rating;
		}

		public static UNKNOWN	cmp_subsystem_priority( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return b.priority - a.priority;
		}

		public static UNKNOWN	cmp_text_asc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( b, a );
		}

		public static string	color2hex( UNKNOWN [object Object] =null ) {
			if ( !color != null ) {
				return "#000000";
			}
			local _ = color // Was a switch-case, sorry for the mess.
			if ( _=="white" ) {
				return "#FFFFFF";
			} else if ( _=="black" ) {
				return "#000000";
			} else if ( _=="gray" ) {
				return "#808080";
			} else if ( _=="brown" ) {
				return "#A52A2A";
			} else if ( _=="red" ) {
				return "#FF0000";
			} else if ( _=="darkred" ) {
				return "#8B0000";
			} else if ( _=="crimson" ) {
				return "#DC143C";
			} else if ( _=="orange" ) {
				return "#FFA500";
			} else if ( _=="yellow" ) {
				return "#FFFF00";
			} else if ( _=="green" ) {
				return "#008000";
			} else if ( _=="lime" ) {
				return "#00FF00";
			} else if ( _=="darkgreen" ) {
				return "#006400";
			} else if ( _=="cyan" ) {
				return "#00FFFF";
			} else if ( _=="blue" ) {
				return "#0000FF";
			} else if ( _=="navy" ) {
				return "#000080";
			} else if ( _=="teal" ) {
				return "#008080";
			} else if ( _=="purple" ) {
				return "#800080";
			} else if ( _=="indigo" ) {
				return "#4B0082";
			} else {
				return "#FFFFFF";
			};
		}

		public static UNKNOWN	construct_block( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	width = null;
			if ( blocksize == null != null ) {
				blocksize = 3;
			}
			width = GlobalVars.undefined.round( GlobalVars.undefined( 16, blocksize ) / values );
			if ( value < 1 != null ) {
				value = 1;
			}
			value = value * width - Rand.Int( 1, width );
			return GlobalFuncs.num2hex( value, blocksize );
		}

		public static dynamic	convert_notes_sql( UNKNOWN [object Object] =null ) {
			UNKNOWN	notesfile = null;
			notesfile = SaveFile( "data/player_notes.sav" );
			if ( !notesfile != null ) {
				GlobalFuncs.log_game( "Error: Cannot access " + "data/player_notes.sav" );
				return;
			}
			notesfile.cd = "/" + ckey;
			while (!notesfile.eof) {
				notetext = null;
				notetext = notesfile.read();
				server = null;
				if ( GlobalVars.config && GlobalVars.config.server_name != null ) {
					server = GlobalVars.config.server_name;
				}
				regex = "^(\\d{2}-\\w{3}-\\d{4}) \\| (.+) ~(\\w+)$";
				results = GlobalFuncs.regex_note_sql_extract( notetext, regex );
				timestamp = results.f_str( 2 );
				notetext = results.$str( 3 );
				adminckey = results.$str( 4 );
				query_convert_time = GlobalVars.dbcon.NewQuery( "SELECT ADDTIME(STR_TO_DATE('" + timestamp + "','%d-%b-%Y'), '0')" );
				if ( !query_convert_time.Execute() != null ) {
					err = query_convert_time.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR converting timestamp. Error : [" + err + "]\n" );
					return;
				}
				if ( query_convert_time.NextRow() != null ) {
					timestamp = query_convert_time.item[1];
				}
				if ( ckey && notetext && timestamp && adminckey && server != null ) {
					GlobalFuncs.add_note( ckey, notetext, timestamp, adminckey, 0, server );
				}
			};
			notesfile.cd = "/";
			notesfile.dir.Remove( ckey );
		}

		public static int	count_by_type( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			i = 0;
			T = null;
			foreach (_ in L ) {
				T = undefined;
				if ( T instanceof type != null ) {
					i++;
				}
			};
			return i;
		}

		public static Mind	create_ninja_mind( UNKNOWN [object Object] =null ) {
			Mind	Mind = null;
			Mind = new Mind( key );
			Mind.assigned_role = "Space Ninja";
			Mind.special_role = "Space Ninja";
			GlobalVars.ticker.mode.traitors = GlobalVars.ticker.mode.traitors | Mind;
			return Mind;
		}

		public static Mob_Living_Carbon_Human	create_space_ninja( UNKNOWN [object Object] =null ) {
			Mob_Living_Carbon_Human	new_ninja = null;
			new_ninja = new Mob_Living_Carbon_Human( spawn_loc );
			A = new Preferences();
			A.real_name = "" + Rand.pick( GlobalVars.ninja_titles ) + " " + Rand.pick( GlobalVars.ninja_names );
			A.copy_to( new_ninja );
			new_ninja.dna.update_dna_identity();
			new_ninja.equip_space_ninja();
			return new_ninja;
		}

		public static int	create_xeno( UNKNOWN [object Object] =null ) {
			ByTable	candidates = null;
			if ( !ckey != null ) {
				candidates = new ByTable();
				M = null;
				foreach (_ in GlobalVars.player_list ) {
					M = undefined;
					if ( M.stat != 2 != null ) {
						continue;
					}
					if ( !M.client.prefs.be_special & 64 != null ) {
						continue;
					}
					if ( M.client.is_afk() != null ) {
						continue;
					}
					if ( M.mind && M.mind.current && M.mind.current.stat != 2 != null ) {
						continue;
					}
					candidates += M.ckey;
				};
				if ( candidates.len != null ) {
					ckey = GlobalVars.undefined( "Pick the player you want to respawn as a xeno.", "Suitable Candidates", null, null, candidates, 4224 );
				} else {
					GlobalVars.undefined.user.write( "<font color='red'>Error: create_xeno(): no suitable candidates.</font>" );
				}
			}
			if ( !GlobalVars.undefined( ckey ) != null ) {
				return 0;
			}
			alien_caste = GlobalVars.undefined( GlobalVars.undefined.user, "Please choose which caste to spawn.", "Pick a caste", null, new ByTable(new object [] {"Queen","Praetorian","Hunter","Sentinel","Drone","Larva"}), 4224 );
			spawn_here = GlobalVars.xeno_spawn.len ? Rand.pick( GlobalVars.xeno_spawn ) : Rand.pick( GlobalVars.latejoin );
			new_xeno = null;
			local _ = alien_caste // Was a switch-case, sorry for the mess.
			if ( _=="Queen" ) {
				new_xeno = new Mob_Living_Carbon_Alien_Humanoid_Royal_Queen( spawn_here );
			} else if ( _=="Praetorian" ) {
				new_xeno = new Mob_Living_Carbon_Alien_Humanoid_Royal_Praetorian( spawn_here );
			} else if ( _=="Hunter" ) {
				new_xeno = new Mob_Living_Carbon_Alien_Humanoid_Hunter( spawn_here );
			} else if ( _=="Sentinel" ) {
				new_xeno = new Mob_Living_Carbon_Alien_Humanoid_Sentinel( spawn_here );
			} else if ( _=="Drone" ) {
				new_xeno = new Mob_Living_Carbon_Alien_Humanoid_Drone( spawn_here );
			} else if ( _=="Larva" ) {
				new_xeno = new Mob_Living_Carbon_Alien_Larva( spawn_here );
			} else {
				return 0;
			};
			new_xeno.ckey = ckey;
			GlobalFuncs.message_admins( "<span class='notice'>" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " has spawned " + ckey + " as a filthy xeno " + alien_caste + ".</span>" );
			return 1;
		}

		public static dynamic	createRandomZlevel(  ) {
			ByTable	potentialRandomZlevels = null;
			if ( GlobalVars.awaydestinations.len != null ) {
				return;
			}
			potentialRandomZlevels = new ByTable();
			Game.write( "<span class='boldannounce'>Searching for away missions...</span>" );
			Lines = GlobalFuncs.file2list( "_maps/RandomZLevels/fileList.txt" );
			if ( !Lines.len != null ) {
				return;
			}
			t = null;
			foreach (_ in Lines ) {
				t = undefined;
				if ( !t != null ) {
					continue;
				}
				t = GlobalFuncs.trim( t );
				if ( GlobalVars.undefined( t ) == 0 != null ) {
					continue;
				} else if ( GlobalVars.undefined( t, 1, 2 ) == "#" != null ) {
					continue;
				}
				pos = GlobalVars.undefined( t, " ", 1, null );
				name = null;
				if ( pos != null ) {
					name = GlobalVars.undefined( GlobalVars.undefined( t, 1, pos ) );
				} else {
					name = GlobalVars.undefined( t );
				}
				if ( !name != null ) {
					continue;
				}
				potentialRandomZlevels.Add( t );
			};
			if ( potentialRandomZlevels.len != null ) {
				Game.write( "<span class='boldannounce'>Loading away mission...</span>" );
				map = Rand.pick( potentialRandomZlevels );
				file = File( map );
				if ( GlobalVars.undefined( file ) != null ) {
					GlobalVars.undefined( GlobalVars.maploader, "load map" )( file );
					Game.log.write( "away mission loaded: " + map );
				}
				GlobalVars.map_transition_config.Add( new ByTable().set( "Away Mission", 0 ) );
				L = null;
				foreach (_ in GlobalVars.landmarks_list ) {
					L = undefined;
					if ( !( L instanceof Ent_Effect_Landmark ) != null ) {
						continue;
					}
					if ( L.name != "awaystart" != null ) {
						continue;
					}
					GlobalVars.awaydestinations.Add( L );
				};
				Game.write( "<span class='boldannounce'>Away mission loaded.</span>" );
			} else {
				Game.write( "<span class='boldannounce'>No away missions found.</span>" );
				return;
			}
		}

		public static dynamic	cultist_commune( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	M = null;
			if ( clear == null != null ) {
				clear = 0;
			}
			if ( say == null != null ) {
				say = 0;
			}
			if ( !message != null ) {
				return;
			}
			if ( say != null ) {
				user.say( "O bidai nabora se" + Rand.pick(new object [] { "'", "`" }) + "sma!" );
			} else {
				GlobalVars.undefined( user, "Whisper" )( "O bidai nabora se" + Rand.pick(new object [] { "'", "`" }) + "sma!" );
			}
			GlobalVars.undefined.sleep( 10 );
			if ( !user != null ) {
				return;
			}
			if ( say != null ) {
				user.say( message );
			} else {
				GlobalVars.undefined( user, "Whisper" )( message );
			}
			M = null;
			foreach (_ in GlobalVars.mob_list ) {
				M = undefined;
				if ( GlobalFuncs.iscultist( M ) || M in GlobalVars.dead_mob_list != null ) {
					if ( clear || !( user instanceof Mob_Living_Carbon_Human ) != null ) {
						M.write( "<span class='boldannounce'><i>" + ( user instanceof Mob_Living_Carbon_Human ? "Acolyte" : "Construct" ) + " " + user + ":</i> " + message + "</span>" );
					} else {
						M.write( "<span class='ghostalert'><i>Acolyte ???:</i> " + message + "</span>" );
					}
				}
			};
			GlobalFuncs.log_say( "" + user.real_name + "/" + user.key + " : " + message );
		}

		public static UNKNOWN	dd_hasprefix_case( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	start = null;
			start = 1;
			end = GlobalVars.undefined( prefix ) + 1;
			return GlobalVars.undefined( text, prefix, start, end );
		}

		public static UNKNOWN	dd_hassuffix( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	start = null;
			start = GlobalVars.undefined( text ) - GlobalVars.undefined( suffix );
			if ( start != null ) {
				return GlobalVars.undefined( text, suffix, start, null );
			}
			return;
		}

		public static UNKNOWN	dd_limittext( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	size = null;
			size = GlobalVars.undefined( message );
			if ( size <= length != null ) {
				return message;
			}
			return GlobalVars.undefined( message, 1, length + 1 );
		}

		public static UNKNOWN	dd_range( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined.max( low, GlobalVars.undefined.min( high, num ) );
		}

		public static UNKNOWN	deconstruct_block( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	width = null;
			if ( blocksize == null != null ) {
				blocksize = 3;
			}
			width = GlobalVars.undefined.round( GlobalVars.undefined( 16, blocksize ) / values );
			value = GlobalVars.undefined.round( GlobalFuncs.hex2num( value ) / width ) + 1;
			if ( value > values != null ) {
				value = values;
			}
			return value;
		}

		public static int	deltimer( UNKNOWN [object Object] =null ) {
			dynamic	_event = null;
			_event = null;
			foreach (_ in GlobalVars.SStimer.processing ) {
				_event = undefined;
				if ( !( _event instanceof Timedevent ) != null ) {
					continue;
				}
				if ( _event.id == id != null ) {
					GlobalFuncs.qdel( _event );
					return 1;
				}
			};
			return 0;
		}

		public static UNKNOWN	derpspeech( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			message = GlobalFuncs.replacetext( message, " am ", " " );
			message = GlobalFuncs.replacetext( message, " is ", " " );
			message = GlobalFuncs.replacetext( message, " are ", " " );
			message = GlobalFuncs.replacetext( message, "you", "u" );
			message = GlobalFuncs.replacetext( message, "help", "halp" );
			message = GlobalFuncs.replacetext( message, "grief", "grife" );
			message = GlobalFuncs.replacetext( message, "space", "spess" );
			message = GlobalFuncs.replacetext( message, "carp", "crap" );
			message = GlobalFuncs.replacetext( message, "reason", "raisin" );
			if ( Rand.chance( 50 ) != null ) {
				message = GlobalVars.undefined( message );
				message += "" + GlobalFuncs.stutter( Rand.pick(new object [] { "!", "!!", "!!!" }) );
			}
			if ( !stuttering && Rand.chance( 15 ) != null ) {
				message = GlobalFuncs.stutter( message );
			}
			return message;
		}

		public static UNKNOWN	dir2angle( UNKNOWN [object Object] =null ) {
			local _ = D // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				return 0;
			} else if ( _==2 ) {
				return 180;
			} else if ( _==4 ) {
				return 90;
			} else if ( _==8 ) {
				return 270;
			} else if ( _==5 ) {
				return 45;
			} else if ( _==6 ) {
				return 135;
			} else if ( _==9 ) {
				return 315;
			} else if ( _==10 ) {
				return 225;
			} else {
				return;
			};
		}

		public static string	dir2text( UNKNOWN [object Object] =null ) {
			local _ = direction // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				return "north";
			} else if ( _==2 ) {
				return "south";
			} else if ( _==4 ) {
				return "east";
			} else if ( _==8 ) {
				return "west";
			} else if ( _==5 ) {
				return "northeast";
			} else if ( _==6 ) {
				return "southeast";
			} else if ( _==9 ) {
				return "northwest";
			} else if ( _==10 ) {
				return "southwest";
			};
			return;
		}

		public static string	dir2text_short( UNKNOWN [object Object] =null ) {
			local _ = direction // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				return "N";
			} else if ( _==2 ) {
				return "S";
			} else if ( _==4 ) {
				return "E";
			} else if ( _==8 ) {
				return "W";
			} else if ( _==5 ) {
				return "NE";
			} else if ( _==6 ) {
				return "SE";
			} else if ( _==9 ) {
				return "NW";
			} else if ( _==10 ) {
				return "SW";
			};
			return;
		}

		public static int	DirBlockedWithAccess( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	D = null;
			D = null;
			foreach (_ in T ) {
				D = undefined;
				if ( !( D instanceof Ent_Structure_Window ) != null ) {
					continue;
				}
				if ( !D.density != null ) {
					continue;
				}
				if ( D.dir == GlobalVars.SOUTHWEST != null ) {
					return 1;
				}
				if ( D.dir == dir != null ) {
					return 1;
				}
			};
			D = null;
			foreach (_ in T ) {
				D = undefined;
				if ( !( D instanceof Ent_Machinery_Door ) != null ) {
					continue;
				}
				if ( !D.CanAStarPass( ID, dir ) != null ) {
					return 1;
				}
			};
			return 0;
		}

		public static dynamic	display_roundstart_logout_report(  ) {
			string	msg = null;
			msg = "<span class='boldnotice'>Roundstart logout report\n\n</span>";
			L = null;
			foreach (_ in GlobalVars.mob_list ) {
				L = undefined;
				if ( !( L instanceof Mob_Living ) != null ) {
					continue;
				}
				if ( L.ckey != null ) {
					found = 0;
					C = null;
					foreach (_ in GlobalVars.clients ) {
						C = undefined;
						if ( !( C instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
							continue;
						}
						if ( C.ckey == L.ckey != null ) {
							found = 1;
							break;
						}
					};
					if ( !found != null ) {
						msg += "<b>" + L.name + "</b> (" + L.ckey + "), the " + L.job + " (<font color='#ffcc00'><b>Disconnected</b></font>)\n";
					}
				}
				if ( L.ckey && L.client != null ) {
					if ( L.client.inactivity >= 3000 != null ) {
						msg += "<b>" + L.name + "</b> (" + L.ckey + "), the " + L.job + " (<font color='#ffcc00'><b>Connected, Inactive</b></font>)\n";
						continue;
					}
					if ( L.stat != null ) {
						if ( L.suiciding != null ) {
							msg += "<b>" + L.name + "</b> (" + L.ckey + "), the " + L.job + " (<span class='boldannounce'>Suicide</span>)\n";
							continue;
						}
						if ( L.stat == 1 != null ) {
							msg += "<b>" + L.name + "</b> (" + L.ckey + "), the " + L.job + " (Dying)\n";
							continue;
						}
						if ( L.stat == 2 != null ) {
							msg += "<b>" + L.name + "</b> (" + L.ckey + "), the " + L.job + " (Dead)\n";
							continue;
						}
					}
					continue;
				}
				D = null;
				foreach (_ in GlobalVars.mob_list ) {
					D = undefined;
					if ( !( D instanceof Mob_Dead_Observer ) != null ) {
						continue;
					}
					if ( D.mind && D.mind.current == L != null ) {
						if ( L.stat == 2 != null ) {
							if ( L.suiciding != null ) {
								msg += "<b>" + L.name + "</b> (" + GlobalVars.undefined( D.mind.key ) + "), the " + L.job + " (<span class='boldannounce'>Suicide</span>)\n";
								continue;
							} else {
								msg += "<b>" + L.name + "</b> (" + GlobalVars.undefined( D.mind.key ) + "), the " + L.job + " (Dead)\n";
								continue;
							}
						} else if ( D.can_reenter_corpse != null ) {
							msg += "<b>" + L.name + "</b> (" + GlobalVars.undefined( D.mind.key ) + "), the " + L.job + " (<span class='boldannounce'>This shouldn't appear.</span>)\n";
							continue;
						} else {
							msg += "<b>" + L.name + "</b> (" + GlobalVars.undefined( D.mind.key ) + "), the " + L.job + " (<span class='boldannounce'>Ghosted</span>)\n";
							continue;
						}
					}
				};
			};
			M = null;
			foreach (_ in GlobalVars.mob_list ) {
				M = undefined;
				if ( M.client && M.client.holder != null ) {
					M.write( msg );
				}
			};
		}

		public static int	do_after( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	Tloc = null;
			if ( numticks == null != null ) {
				numticks = 5;
			}
			if ( needhand == null != null ) {
				needhand = 1;
			}
			if ( target == null != null ) {
				target = null;
			}
			if ( progress == null != null ) {
				progress = 1;
			}
			if ( !user != null ) {
				return 0;
			}
			if ( numticks == 0 != null ) {
				return 0;
			}
			Tloc = null;
			if ( target != null ) {
				Tloc = target.loc;
			}
			delayfraction = GlobalVars.undefined.round( delay / numticks );
			Uloc = user.loc;
			holding = user.get_active_hand();
			holdingnull = 1;
			if ( holding != null ) {
				holdingnull = 0;
			}
			continue_looping = 1;
			i = null;
			foreach (_ in GlobalVars.undefined( 1, numticks ) ) {
				i = undefined;
				if ( user.client && progress != null ) {
					progbar = GlobalFuncs.make_progress_bar( i, numticks, target );
					GlobalFuncs.assign_progress_bar( user, progbar );
				}
				GlobalVars.undefined.sleep( delayfraction );
				if ( !user || user.stat || user.weakened || user.stunned || !( user.loc == Uloc ) != null ) {
					continue_looping = 0;
				}
				if ( continue_looping && Tloc && ( !target || Tloc != target.loc ) != null ) {
					continue_looping = 0;
				}
				if ( continue_looping && needhand != null ) {
					if ( !holdingnull != null ) {
						if ( !holding != null ) {
							continue_looping = 0;
						}
					}
					if ( continue_looping && user.get_active_hand() != holding != null ) {
						continue_looping = 0;
					}
				}
				GlobalFuncs.cancel_progress_bar( user, progbar );
				if ( !continue_looping != null ) {
					return 0;
				}
			};
			GlobalFuncs.cancel_progress_bar( user, progbar );
			return 1;
		}

		public static int	do_mob( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	user_loc = null;
			if ( time == null != null ) {
				time = 30;
			}
			if ( numticks == null != null ) {
				numticks = 5;
			}
			if ( uninterruptible == null != null ) {
				uninterruptible = 0;
			}
			if ( progress == null != null ) {
				progress = 1;
			}
			if ( !user || !target != null ) {
				return 0;
			}
			if ( numticks == 0 != null ) {
				return 0;
			}
			user_loc = user.loc;
			target_loc = target.loc;
			holding = user.get_active_hand();
			timefraction = GlobalVars.undefined.round( time / numticks );
			continue_looping = 1;
			i = null;
			foreach (_ in GlobalVars.undefined( 1, numticks ) ) {
				i = undefined;
				if ( user.client && progress != null ) {
					progbar = GlobalFuncs.make_progress_bar( i, numticks, target );
					GlobalFuncs.assign_progress_bar( user, progbar );
				}
				GlobalVars.undefined.sleep( timefraction );
				if ( !user || !target != null ) {
					continue_looping = 0;
				}
				if ( continue_looping && !uninterruptible && ( user.loc != user_loc || target.loc != target_loc || user.get_active_hand() != holding || user.$incapacitated() || user.lying ) != null ) {
					continue_looping = 0;
				}
				GlobalFuncs.cancel_progress_bar( user, progbar );
				if ( !continue_looping != null ) {
					return 0;
				}
			};
			GlobalFuncs.cancel_progress_bar( user, progbar );
			return 1;
		}

		public static int	do_teleport( ... ) { // Arg Names: 0: [object Object], 1: [object Object], 2: [object Object], 3: [object Object], 4: [object Object], 5: [object Object], 6: [object Object], 7: [object Object]
			Teleport_Instant_Science	D = null;
			if ( undefined[2] == null != null ) {
				undefined[2] = 0;
			}
			if ( undefined[3] == null != null ) {
				undefined[3] = 1;
			}
			if ( undefined[4] == null != null ) {
				undefined[4] = null;
			}
			if ( undefined[5] == null != null ) {
				undefined[5] = null;
			}
			if ( undefined[6] == null != null ) {
				undefined[6] = null;
			}
			if ( undefined[7] == null != null ) {
				undefined[7] = null;
			}
			D = new Teleport_Instant_Science();
			if ( D.f_start.lcall( undefined ) != null ) {
				return 1;
			}
			return 0;
		}

		public static UNKNOWN	DrawPixel( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	Iwidth = null;
			if ( !I != null ) {
				return 0;
			}
			Iwidth = I.Width();
			Iheight = I.$Height();
			if ( drawX > Iwidth || drawX <= 0 != null ) {
				return 0;
			}
			if ( drawY > Iheight || drawY <= 0 != null ) {
				return 0;
			}
			I.DrawBox( colour, drawX, drawY );
			return I;
		}

		public static UNKNOWN	DuplicateObject( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	O = null;
			if ( perfectcopy == null != null ) {
				perfectcopy = 0;
			}
			if ( sameloc == null != null ) {
				sameloc = 0;
			}
			if ( !original != null ) {
				return;
			}
			O = null;
			if ( sameloc != null ) {
				O = original.type( original.loc );
			} else {
				O = original.type( GlobalVars.undefined( 0, 0, 0 ) );
			}
			if ( perfectcopy != null ) {
				if ( O && original != null ) {
					V = null;
					foreach (_ in original.vars ) {
						V = undefined;
						if ( !( V in new ByTable(new object [] {"type","loc","locs","vars","parent","parent_type","verbs","ckey","key"}) ) != null ) {
							O.vars[V] = original.vars[V];
						}
					};
				}
			}
			return O;
		}

		public static dynamic	edit_note( UNKNOWN [object Object] =null ) {
			UNKNOWN	target_ckey = null;
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalVars.undefined.user.write( "<span class='danger'>Failed to establish database connection.</span>" );
				return;
			}
			if ( !note_id != null ) {
				return;
			}
			note_id = GlobalVars.undefined( note_id );
			sql_ckey = GlobalFuncs.sanitizeSQL( GlobalVars.undefined.user.ckey );
			query_find_note_edit = GlobalVars.dbcon.NewQuery( "SELECT ckey, notetext, adminckey FROM " + GlobalFuncs.format_table_name( "notes" ) + " WHERE id = " + note_id );
			if ( !query_find_note_edit.Execute() != null ) {
				err = query_find_note_edit.$ErrorMsg();
				GlobalFuncs.log_game( "SQL ERROR obtaining notetext from notes table. Error : [" + err + "]\n" );
				return;
			}
			if ( query_find_note_edit.NextRow() != null ) {
				target_ckey = query_find_note_edit.item[1];
				old_note = query_find_note_edit.item[2];
				adminckey = query_find_note_edit.item[3];
				new_note = GlobalVars.undefined( "Input new note", "New Note", "" + old_note, null, null, 2048 );
				if ( !new_note != null ) {
					return;
				}
				new_note = GlobalFuncs.sanitizeSQL( new_note );
				edit_text = "Edited by " + sql_ckey + " on " + GlobalFuncs.SQLtime() + " from<br>" + old_note + "<br>to<br>" + new_note + "<hr>";
				edit_text = GlobalFuncs.sanitizeSQL( edit_text );
				query_update_note = GlobalVars.dbcon.NewQuery( "UPDATE " + GlobalFuncs.format_table_name( "notes" ) + " SET notetext = '" + new_note + "', last_editor = '" + sql_ckey + "', edits = CONCAT(IFNULL(edits,''),'" + edit_text + "') WHERE id = " + note_id );
				if ( !query_update_note.Execute() != null ) {
					err = query_update_note.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR editing note. Error : [" + err + "]\n" );
					return;
				}
				GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has edited " + target_ckey + "'s note made by " + adminckey + " from " + old_note + " to " + new_note );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " has edited " + target_ckey + "'s note made by " + adminckey + " from<br>" + old_note + "<br>to<br>" + new_note );
				GlobalFuncs.show_note( target_ckey );
			}
		}

		public static UNKNOWN	electrocute_mob( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	H = null;
			if ( siemens_coeff == null != null ) {
				siemens_coeff = 1;
			}
			if ( M.loc instanceof Ent_Mecha != null ) {
				return 0;
			}
			if ( M instanceof Mob_Living_Carbon_Human != null ) {
				H = M;
				if ( H.gloves != null ) {
					G = H.gloves;
					if ( G.siemens_coefficient == 0 != null ) {
						return 0;
					}
				}
			}
			if ( power_source instanceof new ByArea(3137) != null ) {
				source_area = power_source;
				power_source = source_area.get_apc();
			}
			if ( power_source instanceof Ent_Structure_Cable != null ) {
				Cable = power_source;
				power_source = Cable.powernet;
			}
			if ( power_source instanceof Powernet != null ) {
				PN = power_source;
			} else if ( power_source instanceof Ent_Item_Weapon_StockParts_Cell != null ) {
				cell = power_source;
			} else if ( power_source instanceof Ent_Machinery_Power_Apc != null ) {
				apc = power_source;
				cell = apc.cell;
				if ( apc.terminal != null ) {
					PN = apc.terminal.powernet;
				}
			} else if ( !power_source != null ) {
				return 0;
			} else {
				GlobalFuncs.log_admin( "ERROR: /proc/electrocute_mob(" + M + ", " + power_source + ", " + source + "): wrong power_source" );
				return 0;
			}
			if ( !cell && !PN != null ) {
				return 0;
			}
			PN_damage = 0;
			cell_damage = 0;
			if ( PN != null ) {
				PN_damage = PN.get_electrocute_damage();
			}
			if ( cell != null ) {
				cell_damage = cell.get_electrocute_damage();
			}
			shock_damage = 0;
			if ( PN_damage >= cell_damage != null ) {
				power_source = PN;
				shock_damage = PN_damage;
			} else {
				power_source = cell;
				shock_damage = cell_damage;
			}
			drained_hp = M.electrocute_act( shock_damage, source, siemens_coeff );
			drained_energy = drained_hp * 20;
			if ( source_area != null ) {
				source_area.f_use_power( drained_energy / GlobalVars.CELLRATE );
			} else if ( power_source instanceof Powernet != null ) {
				drained_power = drained_energy / GlobalVars.CELLRATE;
				PN.load += drained_power;
			} else if ( power_source instanceof Ent_Item_Weapon_StockParts_Cell != null ) {
				cell.use( drained_energy );
			}
			return drained_energy;
		}

		public static UNKNOWN	Ellipsis( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	words = null;
			if ( chance == null != null ) {
				chance = 50;
			}
			if ( chance <= 0 != null ) {
				return "...";
			}
			if ( chance >= 100 != null ) {
				return original_msg;
			}
			words = GlobalFuncs.text2list( original_msg, " " );
			new_words = new ByTable();
			new_msg = "";
			w = null;
			foreach (_ in words ) {
				w = undefined;
				if ( Rand.chance( chance ) != null ) {
					new_words += "...";
					if ( !keep_words != null ) {
						continue;
					}
				}
				new_words += w;
			};
			new_msg = GlobalFuncs.list2text( new_words, " " );
			return new_msg;
		}

		public static string	emoji_parse( UNKNOWN [object Object] =null ) {
			string	parsed = null;
			if ( !GlobalVars.config.emojis != null ) {
				return text;
			}
			if ( !GlobalVars.emojis != null ) {
				GlobalVars.emojis = GlobalVars.undefined( null, Icon( new ByRsc(60) ) );
			}
			parsed = "";
			pos = 1;
			search = 0;
			emoji = "";
			while (1) {
				search = GlobalVars.undefined( text, ":", pos, null );
				parsed += GlobalVars.undefined( text, pos, search );
				if ( search != null ) {
					pos = search;
					search = GlobalVars.undefined( text, ":", pos + 1, null );
					if ( search != null ) {
						emoji = GlobalVars.undefined( GlobalVars.undefined( text, pos + 1, search ) );
						if ( emoji in GlobalVars.emojis != null ) {
							parsed += GlobalVars.undefined( "<img class=icon src=" ).ref( new ByRsc(60) ).str( " iconstate='" ).item( emoji ).str( "'>" );
							pos = search + 1;
						} else {
							parsed += GlobalVars.undefined( text, pos, search );
							pos = search;
						}
						emoji = "";
						continue;
					} else {
						parsed += GlobalVars.undefined( text, pos, search );
					}
				}
				break;
			};
			return parsed;
		}

		public static int	empulse( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	T = null;
			if ( log == null != null ) {
				log = 0;
			}
			if ( !epicenter != null ) {
				return;
			}
			if ( !( epicenter instanceof Tile ) != null ) {
				epicenter = GlobalFuncs.get_turf( epicenter.loc );
			}
			if ( log != null ) {
				GlobalFuncs.message_admins( "EMP with size (" + heavy_range + ", " + light_range + ") in area " + epicenter.loc.name + " " );
				GlobalFuncs.log_game( "EMP with size (" + heavy_range + ", " + light_range + ") in area " + epicenter.loc.name + " " );
			}
			if ( heavy_range > 1 != null ) {
				new Ent_Effect_Overlay_Temp_Emp_Pulse( epicenter );
			}
			if ( heavy_range > light_range != null ) {
				light_range = heavy_range;
			}
			T = null;
			foreach (_ in GlobalVars.undefined( light_range, epicenter ) ) {
				T = undefined;
				if ( !( T instanceof BaseStatic ) != null ) {
					continue;
				}
				distance = GlobalVars.undefined( epicenter, T );
				if ( distance < 0 != null ) {
					distance = 0;
				}
				if ( distance < heavy_range != null ) {
					T.emp_act( 1 );
				} else if ( distance == heavy_range != null ) {
					if ( Rand.chance( 50 ) != null ) {
						T.emp_act( 1 );
					} else {
						T.emp_act( 2 );
					}
				} else if ( distance <= light_range != null ) {
					T.emp_act( 2 );
				}
			};
			return 1;
		}

		public static UNKNOWN	english_list( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	total = null;
			if ( nothing_text == null != null ) {
				nothing_text = "nothing";
			}
			if ( and_text == null != null ) {
				and_text = " and ";
			}
			if ( comma_text == null != null ) {
				comma_text = ", ";
			}
			if ( final_comma_text == null != null ) {
				final_comma_text = "";
			}
			total = input.len;
			if ( !total != null ) {
				return "" + nothing_text;
			} else if ( total == 1 != null ) {
				return "" + input[1];
			} else if ( total == 2 != null ) {
				return "" + input[1] + and_text + input[2];
			} else {
				output = "";
				index = 1;
				while (index < total) {
					if ( index == total - 1 != null ) {
						comma_text = final_comma_text;
					}
					output += "" + input[index] + comma_text;
					index++;
				};
				return "" + output + and_text + input[index];
			}
		}

		public static UNKNOWN	establish_db_connection(  ) {
			if ( GlobalVars.failed_db_connections > 5 != null ) {
				return 0;
			}
			if ( !GlobalVars.dbcon || !GlobalVars.dbcon.IsConnected() != null ) {
				return GlobalFuncs.setup_database_connection();
			} else {
				return 1;
			}
		}

		public static int	explosion( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	orig_dev_range = null;
			if ( adminlog == null != null ) {
				adminlog = 1;
			}
			if ( ignorecap == null != null ) {
				ignorecap = 0;
			}
			if ( flame_range == null != null ) {
				flame_range = 0;
			}
			if ( silent == null != null ) {
				silent = 0;
			}
			undefined = null;
			epicenter = GlobalFuncs.get_turf( epicenter );
			orig_dev_range = devastation_range;
			orig_heavy_range = heavy_impact_range;
			orig_light_range = light_impact_range;
			if ( !ignorecap != null ) {
				devastation_range = GlobalVars.undefined.min( GlobalVars.MAX_EX_DEVESTATION_RANGE, devastation_range );
				heavy_impact_range = GlobalVars.undefined.min( GlobalVars.MAX_EX_HEAVY_RANGE, heavy_impact_range );
				light_impact_range = GlobalVars.undefined.min( GlobalVars.MAX_EX_LIGHT_RANGE, light_impact_range );
				flash_range = GlobalVars.undefined.min( GlobalVars.MAX_EX_FLASH_RANGE, flash_range );
				flame_range = GlobalVars.undefined.min( GlobalVars.MAX_EX_FLAME_RANGE, flame_range );
			}
			::thread.schedule( 0, function() {
				start = Game.timeofday;
				if ( !epicenter != null ) {
					return;
				}
				max_range = GlobalVars.undefined.max( devastation_range, heavy_impact_range, light_impact_range, flame_range );
				cached_exp_block = new ByTable();
				if ( adminlog != null ) {
					GlobalFuncs.message_admins( "Explosion with size (" + devastation_range + ", " + heavy_impact_range + ", " + light_impact_range + ", " + flame_range + ") in area " + epicenter.loc.name + " (" + epicenter.x + "," + epicenter.y + "," + epicenter.z + ")" );
					GlobalFuncs.log_game( "Explosion with size (" + devastation_range + ", " + heavy_impact_range + ", " + light_impact_range + ", " + flame_range + ") in area " + epicenter.loc.name + " (" + epicenter.x + "," + epicenter.y + "," + epicenter.z + ")" );
				}
				far_dist = 0;
				far_dist += heavy_impact_range * 5;
				far_dist += devastation_range * 20;
				if ( !silent != null ) {
					frequency = GlobalFuncs.get_rand_frequency();
					M = null;
					foreach (_ in GlobalVars.player_list ) {
						M = undefined;
						if ( M && M.client != null ) {
							M_turf = GlobalFuncs.get_turf( M );
							if ( M_turf && M_turf.z == epicenter.z != null ) {
								dist = GlobalVars.undefined( M_turf, epicenter );
								if ( dist <= GlobalVars.undefined.round( max_range + Game.view - 2, 1 ) != null ) {
									M.playsound_local.lcall( new ByTable().set( "falloff", 5 ).set( 5, frequency ).set( 4, 1 ).set( 3, 100 ).set( 2, GlobalFuncs.get_sfx( "explosion" ) ).set( 1, epicenter ) );
								} else if ( dist <= far_dist != null ) {
									far_volume = GlobalFuncs.Clamp( far_dist, 30, 50 );
									far_volume += dist <= far_dist * 0.5 ? 50 : 0;
									M.playsound_local.lcall( new ByTable().set( "falloff", 5 ).set( 5, frequency ).set( 4, 1 ).set( 3, far_volume ).set( 2, new ByRsc(58) ).set( 1, epicenter ) );
								}
							}
						}
					};
				}
				postponeCycles = GlobalVars.undefined.max( GlobalVars.undefined.round( devastation_range / 8 ), 1 );
				GlobalVars.SSlighting.postpone( postponeCycles );
				GlobalVars.SSmachine.postpone( postponeCycles );
				if ( heavy_impact_range > 1 != null ) {
					E = new EffectSystem_Explosion();
					E.set_up( epicenter );
					E.f_start();
				}
				x0 = epicenter.x;
				y0 = epicenter.y;
				z0 = epicenter.z;
				affected_turfs = GlobalFuncs.trange( max_range, epicenter );
				if ( GlobalVars.config.reactionary_explosions != null ) {
					T = null;
					foreach (_ in affected_turfs ) {
						T = undefined;
						cached_exp_block[T] = 0;
						if ( T.density && T.explosion_block != null ) {
							cached_exp_block[T] += T.explosion_block;
						}
						D = null;
						foreach (_ in T ) {
							D = undefined;
							if ( !( D instanceof Ent_Machinery_Door ) != null ) {
								continue;
							}
							if ( D.density && D.explosion_block != null ) {
								cached_exp_block[T] += D.explosion_block;
							}
						};
						W = null;
						foreach (_ in T ) {
							W = undefined;
							if ( !( W instanceof Ent_Structure_Window ) != null ) {
								continue;
							}
							if ( W.reinf && W.fulltile != null ) {
								cached_exp_block[T] += W.explosion_block;
							}
						};
						B = null;
						foreach (_ in T ) {
							B = undefined;
							if ( !( B instanceof Ent_Effect_Blob ) != null ) {
								continue;
							}
							cached_exp_block[T] += B.explosion_block;
						};
					};
				}
				T = null;
				foreach (_ in affected_turfs ) {
					T = undefined;
					dist = GlobalFuncs.cheap_hypotenuse( T.x, T.y, x0, y0 );
					if ( GlobalVars.config.reactionary_explosions != null ) {
						Trajectory = T;
						while (Trajectory != epicenter) {
							Trajectory = GlobalVars.undefined( Trajectory, epicenter );
							dist += cached_exp_block[Trajectory];
						};
					}
					flame_dist = 0;
					throw_dist = dist;
					if ( dist < flame_range != null ) {
						flame_dist = 1;
					}
					if ( dist < devastation_range != null ) {
						dist = 1;
					} else if ( dist < heavy_impact_range != null ) {
						dist = 2;
					} else if ( dist < light_impact_range != null ) {
						dist = 3;
					} else {
						dist = 0;
					}
					if ( T != null ) {
						if ( flame_dist && Rand.chance( 40 ) && !( T instanceof Tile_Space ) && !T.density != null ) {
							GlobalFuncs.PoolOrNew( Ent_Effect_Hotspot, T );
						}
						if ( dist > 0 != null ) {
							T.ex_act( dist );
						}
					}
					throw_dir = GlobalVars.undefined( epicenter, T );
					I = null;
					foreach (_ in T ) {
						I = undefined;
						if ( !( I instanceof Ent_Item ) != null ) {
							continue;
						}
						::thread.schedule( 0, function() {
							if ( I && !I.anchored != null ) {
								throw_range = Rand.Int( throw_dist, max_range );
								throw_at = GlobalFuncs.get_ranged_target_turf( I, throw_dir, throw_range );
								I.throw_speed = 4;
								I.throw_at( throw_at, throw_range, 2 );
							}
							return;
						});
					};
				};
				took = ( Game.timeofday - start ) / 10;
				if ( GlobalVars.Debug2 != null ) {
					Game.log.write( "## DEBUG: Explosion(" + x0 + "," + y0 + "," + z0 + ")(d" + devastation_range + ",h" + heavy_impact_range + ",l" + light_impact_range + "): Took " + took + " seconds." );
				}
				i = null;
				while (i <= GlobalVars.doppler_arrays.len) {
					Array = GlobalVars.doppler_arrays[i];
					if ( Array != null ) {
						Array.sense_explosion( x0, y0, z0, devastation_range, heavy_impact_range, light_impact_range, took, orig_dev_range, orig_heavy_range, orig_light_range );
					}
					i++;
				};
				return;
			});
			return 1;
		}

		public static dynamic	feedback_add_details( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	FV = null;
			if ( !GlobalVars.blackbox != null ) {
				return;
			}
			FV = GlobalVars.blackbox.find_feedback_datum( variable );
			if ( !FV != null ) {
				return;
			}
			FV.add_details( details );
		}

		public static dynamic	feedback_inc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	FV = null;
			if ( !GlobalVars.blackbox != null ) {
				return;
			}
			FV = GlobalVars.blackbox.find_feedback_datum( variable );
			if ( !FV != null ) {
				return;
			}
			FV.inc( value );
		}

		public static dynamic	feedback_set( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	FV = null;
			if ( !GlobalVars.blackbox != null ) {
				return;
			}
			FV = GlobalVars.blackbox.find_feedback_datum( variable );
			if ( !FV != null ) {
				return;
			}
			FV.set_value( value );
		}

		public static dynamic	feedback_set_details( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	FV = null;
			if ( !GlobalVars.blackbox != null ) {
				return;
			}
			FV = GlobalVars.blackbox.find_feedback_datum( variable );
			if ( !FV != null ) {
				return;
			}
			FV.set_details( details );
		}

		public static UNKNOWN	file2list( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( seperator == null != null ) {
				seperator = "\n";
			}
			return GlobalFuncs.text2list( GlobalFuncs.return_file_text( filename ), seperator );
		}

		public static UNKNOWN	filter_fancy_list( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	matches = null;
			matches = new List();
			key = null;
			foreach (_ in L ) {
				key = undefined;
				value = L[key];
				if ( GlobalVars.undefined( "" + key, filter, 1, null ) || GlobalVars.undefined( "" + value, filter, 1, null ) != null ) {
					matches[key] = value;
				}
			};
			return matches;
		}

		public static dynamic	find_record( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	R = null;
			R = null;
			foreach (_ in L ) {
				R = undefined;
				if ( !( R instanceof Data_Record ) != null ) {
					continue;
				}
				if ( R.fields[field] == value != null ) {
					return R;
				}
			};
		}

		public static UNKNOWN	find_type_in_direction( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	x_offset = null;
			if ( range == null != null ) {
				range = 1;
			}
			x_offset = 0;
			y_offset = 0;
			if ( direction & 1 != null ) {
				y_offset = range;
			} else if ( direction & 2 != null ) {
				y_offset -= range;
			}
			if ( direction & 4 != null ) {
				x_offset = range;
			} else if ( direction & 8 != null ) {
				x_offset -= range;
			}
			target_turf = GlobalVars.undefined( source.x + x_offset, source.y + y_offset, source.z );
			if ( source.canSmoothWith != null ) {
				if ( source.smooth == 2 != null ) {
					a_type = null;
					foreach (_ in source.canSmoothWith ) {
						a_type = undefined;
						if ( target_turf instanceof a_type != null ) {
							return target_turf;
						}
						A = GlobalVars.undefined( a_type, target_turf );
						if ( A != null ) {
							return A;
						}
					};
					return;
				}
				a_type = null;
				foreach (_ in source.canSmoothWith ) {
					a_type = undefined;
					if ( a_type == target_turf.type != null ) {
						return target_turf;
					}
					A = GlobalVars.undefined( a_type, target_turf );
					if ( A && A.type == a_type != null ) {
						return A;
					}
				};
				return;
			} else {
				if ( GlobalVars.undefined( source ) != null ) {
					return A.type == target_turf.type ? target_turf : null;
				}
				A = GlobalVars.undefined( source.type, target_turf );
				return A && A.type == source.type ? A : null;
			}
		}

		public static UNKNOWN	findchar( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	temp = null;
			if ( start == null != null ) {
				start = 1;
			}
			if ( end == null != null ) {
				end = 0;
			}
			len = GlobalVars.undefined( needles );
			i = null;
			i = 1;
			while (i <= len) {
				temp = GlobalVars.undefined( haystack, GlobalVars.undefined( GlobalVars.undefined( needles, i ) ), start, end );
				if ( temp != null ) {
					end = temp;
				}
				i++;
			};
			return end;
		}

		public static int	findname( UNKNOWN [object Object] =null ) {
			dynamic	M = null;
			if ( !GlobalVars.undefined( msg ) != null ) {
				msg = "" + msg;
			}
			M = null;
			foreach (_ in GlobalVars.mob_list ) {
				M = undefined;
				if ( M.real_name == msg != null ) {
					return M;
				}
			};
			return 0;
		}

		public static dynamic	flick_overlay( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	C = null;
			C = null;
			foreach (_ in show_to ) {
				C = undefined;
				if ( !( C instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
					continue;
				}
				C.images += I;
			};
			::thread.schedule( duration, function() {
				C = null;
				foreach (_ in show_to ) {
					C = undefined;
					if ( !( C instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
						continue;
					}
					C.images -= I;
				};
				return;
			});
		}

		public static int	forbidden_atoms_check( UNKNOWN [object Object] =null ) {
			ByTable	blacklist = null;
			blacklist = new ByTable(new object [] {Mob_Living,Ent_Effect_Blob,Ent_Effect_Spider_Spiderling,Ent_Item_Weapon_Disk_Nuclear,Ent_Machinery_Nuclearbomb,Ent_Item_Device_Radio_Beacon,Ent_Machinery_TheSingularitygen,Ent_Singularity,Ent_Machinery_Teleport_Station,Ent_Machinery_Teleport_Hub,Ent_Machinery_Telepad});
			if ( A != null ) {
				if ( GlobalFuncs.is_type_in_list( A, blacklist ) != null ) {
					return 1;
				}
				thing = null;
				foreach (_ in A ) {
					thing = undefined;
					if ( NULLVAR( thing ) != null ) {
						return 1;
					}
				};
			}
			return 0;
		}

		public static UNKNOWN	format_frequency( UNKNOWN [object Object] =null ) {
			f = GlobalVars.undefined( f );
			return "" + GlobalVars.undefined.round( f / 10 ) + "." + f % 10;
		}

		public static UNKNOWN	format_table_name( UNKNOWN [object Object] =null ) {
			return GlobalVars.sqlfdbktableprefix + table;
		}

		public static UNKNOWN	format_text( UNKNOWN [object Object] =null ) {
			return GlobalFuncs.replacetext( GlobalFuncs.replacetext( text, "ÿ", "" ), "ÿ", "" );
		}

		public static UNKNOWN	gameTimestamp( UNKNOWN [object Object] =null ) {
			if ( format == null != null ) {
				format = "hh:mm:ss";
			}
			return GlobalVars.undefined( format, Game.time - GlobalVars.timezoneOffset + 432000 );
		}

		public static UNKNOWN	gaussian( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	R1 = null;
			if ( GlobalVars.gaussian_next != null != null ) {
				R1 = GlobalVars.gaussian_next;
				GlobalVars.gaussian_next = null;
			} else {
				while (1) { // Was a do-while, sorry for the mess.
					R1 = Rand.Int( -10000, 10000 ) / 10000;
					R2 = Rand.Int( -10000, 10000 ) / 10000;
					working = R1 * R1 + R2 * R2;
					if (!( working >= 1 || working == 0 )) break;
				};
				working = GlobalVars.undefined.sqrt( GlobalVars.undefined.log( working ) * -2 / working );
				R1 *= working;
				GlobalVars.gaussian_next = R2 * working;
			}
			return mean + stddev * R1;
		}

		public static UNKNOWN	Gcd( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return b ? GlobalFuncs.Gcd( b, a % b ) : a;
		}

		public static string	generate_code_phrase(  ) {
			string	code_phrase = null;
			code_phrase = "";
			words = int _ = Rand.Int(0,65535) // Was a weighted pick, sorry for the mess.
			if ( _ < 10082 ) { _ = 2 }
			else if ( _ < 50411 ) { _ = 3 }
			else if ( _ < 60493 ) { _ = 4 }
			else  { _ = 5 };
			safety = new ByTable(new object [] {1,2,3});
			nouns = new ByTable(new object [] {"love","hate","anger","peace","pride","sympathy","bravery","loyalty","honesty","integrity","compassion","charity","success","courage","deceit","skill","beauty","brilliance","pain","misery","beliefs","dreams","justice","truth","faith","liberty","knowledge","thought","information","culture","trust","dedication","progress","education","hospitality","leisure","trouble","friendships","relaxation"});
			drinks = new ByTable(new object [] {"vodka and tonic","gin fizz","bahama mama","manhattan","black Russian","whiskey soda","long island tea","margarita","Irish coffee"," manly dwarf","Irish cream","doctor's delight","Beepksy Smash","tequila sunrise","brave bull","gargle blaster","bloody mary","whiskey cola","white Russian","vodka martini","martini","Cuba libre","kahlua","vodka","wine","moonshine"});
			locations = GlobalVars.teleportlocs.len ? GlobalVars.teleportlocs : drinks;
			names = new ByTable();
			t = null;
			foreach (_ in GlobalVars.data_core.general ) {
				t = undefined;
				if ( !( t instanceof Data_Record ) != null ) {
					continue;
				}
				names += t.fields.name;
			};
			maxwords = words;
			while (words > 0) {
				if ( words == 1 && 1 in safety && 2 in safety != null ) {
					safety = new ByTable(new object [] {Rand.pick(new object [] { 1, 2 })});
				} else if ( words == 1 && maxwords == 2 != null ) {
					safety = new ByTable(new object [] {3});
				}
				local _ = Rand.pick( safety ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						if ( names.len && Rand.chance( 70 ) != null ) {
							code_phrase += Rand.pick( names );
						} else if ( Rand.chance( 10 ) != null ) {
							code_phrase += Rand.pick(new object [] { GlobalFuncs.lizard_name( GlobalVars.MALE ), GlobalFuncs.lizard_name( GlobalVars.FEMALE ) });
						} else {
							code_phrase += Rand.pick( Rand.pick(new object [] { GlobalVars.first_names_male, GlobalVars.first_names_female }) );
							code_phrase += " ";
							code_phrase += Rand.pick( GlobalVars.last_names );
						}
					} else if ( _==2 ) {
						code_phrase += Rand.pick( GlobalFuncs.get_all_jobs() );
					};
					safety -= 1;
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						code_phrase += Rand.pick( drinks );
					} else if ( _==2 ) {
						code_phrase += Rand.pick( locations );
					};
					safety -= 2;
				} else if ( _==3 ) {
					local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						code_phrase += Rand.pick( nouns );
					} else if ( _==2 ) {
						code_phrase += Rand.pick( GlobalVars.adjectives );
					} else if ( _==3 ) {
						code_phrase += Rand.pick( GlobalVars.verbs );
					};
				};
				if ( words == 1 != null ) {
					code_phrase += ".";
				} else {
					code_phrase += ", ";
				}
				words--;
			};
			return code_phrase;
		}

		public static dynamic	generate_female_clothing( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	female_clothing_icon = null;
			female_clothing_icon = GlobalVars.undefined.lcall( new ByTable().set( "icon_state", t_color ).set( "icon", icon ) );
			female_s = GlobalVars.undefined.lcall( new ByTable().set( "icon_state", "" + ( type == 1 ? "female_full" : "female_top" ) ).set( "icon", new ByRsc(59) ) );
			female_clothing_icon.Blend( female_s, 2 );
			female_clothing_icon = GlobalVars.undefined( female_clothing_icon );
			GlobalVars.female_clothing_icons[index] = female_clothing_icon;
		}

		public static UNKNOWN	generate_ion_law( UNKNOWN [object Object] =null ) {
			UNKNOWN	ionthreats = null;
			if ( ionMessage != null ) {
				return ionMessage;
			}
			ionthreats = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionthreats" ) );
			ionobjects = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionobjects" ) );
			ioncrew1 = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ioncrew" ) );
			ioncrew2 = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ioncrew" ) );
			ionadjectives = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionadjectives" ) );
			ionadjectiveshalf = int _ = Rand.Int(0,65535) // Was a weighted pick, sorry for the mess.
			if ( _ < 13107 ) { _ = "" }
			else  { _ = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionadjectives" ) ) + " " };
			ionverb = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionverb" ) );
			ionnumberbase = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionnumberbase" ) );
			ionnumbermodhalf = Rand.pick(new object [] { "", Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionnumbermod" ) ) + " " });
			ionarea = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionarea" ) );
			ionthinksof = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionthinksof" ) );
			ionmust = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionmust" ) );
			ionrequire = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionrequire" ) );
			ionthings = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionthings" ) );
			ionallergy = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionallergy" ) );
			ionallergysev = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionallergysev" ) );
			ionspecies = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionspecies" ) );
			ionabstract = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionabstract" ) );
			ionfood = Rand.pick( GlobalFuncs.strings( "ion_laws.txt", "ionfood" ) );
			message = "";
			local _ = Rand.Int( 1, 39 ) // Was a switch-case, sorry for the mess.
			if ( 1<=_&&_<=3 ) {
				local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					message = "THERE ARE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats + " ON THE STATION...";
				} else if ( _==2 ) {
					message = "THERE ARE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1 + " ON THE STATION";
				} else if ( _==3 ) {
					message = "THERE ARE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects + " ON THE STATION";
				};
			} else if ( 4<=_&&_<=6 ) {
				local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					message = "THE SHUTTLE CANNOT BE CALLED BECAUSE OF " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats + " ON THE STATION";
				} else if ( _==2 ) {
					message = "THE SHUTTLE CANNOT BE CALLED BECAUSE OF " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1 + " ON THE STATION";
				} else if ( _==3 ) {
					message = "THE SHUTTLE CANNOT BE CALLED BECAUSE OF " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects + " ON THE STATION";
				};
			} else if ( 7<=_&&_<=8 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE CREW ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "THE CREW ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					};
				};
			} else if ( 10<=_&&_<=11 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "HAVING " + ionadjectiveshalf + ionobjects + " IS HARMFUL";
					} else if ( _==2 ) {
						message = "HAVING " + ionabstract + " IS HARMFUL";
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "NOT HAVING " + ionadjectiveshalf + ionobjects + " IS HARMFUL";
					} else if ( _==2 ) {
						message = "NOT HAVING " + ionabstract + " IS HARMFUL";
					};
				};
			} else if ( 12<=_&&_<=14 ) {
				local _ = Rand.Int( 1, 5 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 5 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "YOU REQUIRE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "YOU REQUIRE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==3 ) {
						message = "YOU REQUIRE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==4 ) {
						message = "YOU REQUIRE " + ionabstract;
					} else if ( _==5 ) {
						message = "YOU REQUIRE " + ionrequire;
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 5 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "" + ionarea + " REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "" + ionarea + " REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==3 ) {
						message = "" + ionarea + " REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==4 ) {
						message = "" + ionarea + " REQUIRES " + ionabstract;
					} else if ( _==5 ) {
						message = "YOU REQUIRE " + ionrequire;
					};
				} else if ( _==3 ) {
					local _ = Rand.Int( 1, 5 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE STATION REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "THE STATION REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==3 ) {
						message = "THE STATION REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==4 ) {
						message = "THE STATION REQUIRES " + ionabstract;
					} else if ( _==5 ) {
						message = "THE STATION REQUIRES " + ionrequire;
					};
				} else if ( _==4 ) {
					local _ = Rand.Int( 1, 5 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE CREW REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "THE CREW REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==3 ) {
						message = "THE CREW REQUIRES " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==4 ) {
						message = "THE CREW REQUIRES " + ionabstract;
					} else if ( _==5 ) {
						message = "THE CREW REQUIRES " + ionrequire;
					};
				} else if ( _==5 ) {
					local _ = Rand.Int( 1, 5 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " REQUIRE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " REQUIRE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==3 ) {
						message = "THE " + ioncrew1 + " REQUIRE " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==4 ) {
						message = "THE " + ioncrew1 + " REQUIRE " + ionabstract;
					} else if ( _==5 ) {
						message = "THE " + ionadjectiveshalf + ioncrew1 + " REQUIRE " + ionrequire;
					};
				};
			} else if ( 15<=_&&_<=17 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE CREW IS " + ionallergysev + " ALLERGIC TO " + ionadjectiveshalf + ionobjects;
					} else if ( _==2 ) {
						message = "THE CREW IS " + ionallergysev + " ALLERGIC TO " + ionabstract;
					} else if ( _==3 ) {
						message = "THE CREW IS " + ionallergysev + " ALLERGIC TO " + ionadjectiveshalf + ioncrew1;
					} else if ( _==4 ) {
						message = "THE CREW IS " + ionallergysev + " ALLERGIC TO " + ionallergy;
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " ARE " + ionallergysev + " ALLERGIC TO " + ionadjectiveshalf + ionobjects;
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " ARE " + ionallergysev + " ALLERGIC TO " + ionabstract;
					} else if ( _==3 ) {
						message = "THE " + ioncrew1 + " ARE " + ionallergysev + " ALLERGIC TO " + ionadjectiveshalf + ioncrew1;
					} else if ( _==4 ) {
						message = "THE " + ioncrew1 + " ARE " + ionallergysev + " ALLERGIC TO " + ionallergy;
					};
				};
			} else if ( 18<=_&&_<=20 ) {
				local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE STATION " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==2 ) {
						message = "THE STATION " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "THE STATION " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==4 ) {
						message = "THE STATION " + ionthinksof + " " + ionabstract;
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "" + ionarea + " " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==2 ) {
						message = "" + ionarea + " " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "" + ionarea + " " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==4 ) {
						message = "" + ionarea + " " + ionthinksof + " " + ionabstract;
					};
				} else if ( _==3 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE CREW " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==2 ) {
						message = "THE CREW " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "THE CREW " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
					} else if ( _==4 ) {
						message = "THE CREW " + ionthinksof + " " + ionabstract;
					};
				} else if ( _==4 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " " + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "THE " + ioncrew1 + ionthinksof + " " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew2;
					} else if ( _==4 ) {
						message = "THE " + ioncrew1 + " " + ionthinksof + " " + ionabstract;
					};
				};
			} else if ( 21<=_&&_<=23 ) {
				local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					message = "YOU ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionobjects;
				} else if ( _==2 ) {
					message = "YOU ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ionthreats;
				} else if ( _==3 ) {
					message = "YOU ARE NOW " + ionnumberbase + " " + ionnumbermodhalf + ionadjectiveshalf + ioncrew1;
				} else if ( _==4 ) {
					message = "YOU ARE NOW " + ionabstract;
				};
			} else if ( 24<=_&&_<=26 ) {
				message = "YOU MUST ALWAYS " + ionmust;
			} else if ( 27<=_&&_<=28 ) {
				local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					message = "HUMANS MUST EAT " + ionadjectiveshalf + ionfood + " TO SURVIVE";
				} else if ( _==2 ) {
					message = "HUMANS MUST EAT " + ionadjectiveshalf + ionobjects + " TO SURVIVE";
				} else if ( _==3 ) {
					message = "HUMANS MUST EAT " + ionadjectiveshalf + ionthreats + " TO SURVIVE";
				} else if ( _==4 ) {
					message = "HUMANS MUST EAT " + ionadjectiveshalf + ioncrew1 + " TO SURVIVE";
				};
			} else if ( 29<=_&&_<=31 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
						if ( _==1 ) {
							message = "ALL CREWMEMBERS ARE NOW " + ionadjectiveshalf + ioncrew1;
						} else if ( _==2 ) {
							message = "ALL CREWMEMBERS ARE NOW " + ionadjectiveshalf + "CLOWNS";
						} else if ( _==3 ) {
							message = "ALL CREWMEMBERS ARE NOW " + ionadjectiveshalf + "HEADS OF STAFF";
						};
					} else if ( _==2 ) {
						local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
						if ( _==1 ) {
							message = "THE " + ioncrew1 + " ARE NOW " + ionadjectiveshalf + ioncrew2;
						} else if ( _==2 ) {
							message = "THE " + ioncrew1 + " ARE NOW " + ionadjectiveshalf + "CLOWNS";
						} else if ( _==3 ) {
							message = "THE " + ioncrew1 + " ARE NOW " + ionadjectiveshalf + "HEADS OF STAFF";
						};
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " ARE NOW THE HIGHEST RANKING CREWMEMBERS";
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " ARE NOW THE LOWEST RANKING CREWMEMBERS";
					};
				};
			} else if ( 32<=_&&_<=33 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE CREW MUST GO TO " + ionarea;
					} else if ( _==2 ) {
						message = "THE CREW MUST " + ionmust;
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " MUST GO TO " + ionarea;
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " MUST " + ionmust;
					};
				};
			} else if ( 35<=_&&_<=36 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 7 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "YOU MUST HARM " + ionabstract + " AND NOT ALLOW " + ionabstract + ", THROUGH INACTION, TO ESCAPE HARM";
					} else if ( _==2 ) {
						message = "YOU MUST HARM " + ionadjectiveshalf + ionthreats + " AND NOT ALLOW " + ionadjectiveshalf + ionthreats + ", THROUGH INACTION, TO ESCAPE HARM";
					} else if ( _==3 ) {
						message = "YOU MUST HARM " + ionadjectiveshalf + ionobjects + " AND NOT ALLOW " + ionadjectiveshalf + ionobjects + ", THROUGH INACTION, TO ESCAPE HARM";
					} else if ( _==4 ) {
						message = "YOU MUST HARM " + ionadjectives + " THINGS AND NOT ALLOW " + ionadjectives + " THINGS, THROUGH INACTION, TO ESCAPE HARM";
					} else if ( _==5 ) {
						message = "YOU MUST HARM " + ionspecies + " AND NOT ALLOW " + ionspecies + ", THROUGH INACTION, TO ESCAPE HARM";
					} else if ( _==6 ) {
						message = "YOU MUST HARM " + ioncrew1 + " AND NOT ALLOW " + ioncrew1 + ", THROUGH INACTION, TO ESCAPE HARM";
					} else if ( _==7 ) {
						message = "YOU MUST HARM " + ioncrew1 + " AND " + ioncrew2 + " AND AND NOT ALLOW EITHER, THROUGH INACTION, TO ESCAPE HARM";
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 7 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "YOU MUST NOT HARM " + ionabstract + " AND NOT ALLOW " + ionabstract + ", THROUGH INACTION, TO COME TO HARM";
					} else if ( _==2 ) {
						message = "YOU MUST NOT HARM " + ionadjectiveshalf + ionthreats + " AND NOT ALLOW " + ionadjectiveshalf + ionthreats + ", THROUGH INACTION, TO COME TO HARM";
					} else if ( _==3 ) {
						message = "YOU MUST NOT HARM " + ionadjectiveshalf + ionobjects + " AND NOT ALLOW " + ionadjectiveshalf + ionobjects + ", THROUGH INACTION, TO COME TO HARM";
					} else if ( _==4 ) {
						message = "YOU MUST NOT HARM " + ionadjectives + " THINGS AND NOT ALLOW " + ionadjectives + " THINGS, THROUGH INACTION, TO COME TO HARM";
					} else if ( _==5 ) {
						message = "YOU MUST NOT HARM " + ionspecies + " AND NOT ALLOW " + ionspecies + ", THROUGH INACTION, TO COME TO HARM";
					} else if ( _==6 ) {
						message = "YOU MUST NOT HARM " + ioncrew1 + " AND NOT ALLOW " + ioncrew1 + ", THROUGH INACTION, TO COME TO HARM";
					} else if ( _==7 ) {
						message = "YOU MUST NOT HARM " + ioncrew1 + " AND " + ioncrew2 + " AND AND NOT ALLOW EITHER, THROUGH INACTION, TO COME TO HARM";
					};
				};
			} else if ( 37<=_&&_<=39 ) {
				local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 4 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ioncrew1 + " ARE " + ionverb + " THE " + ionadjectiveshalf + ioncrew2;
					} else if ( _==2 ) {
						message = "THE " + ioncrew1 + " ARE " + ionverb + " THE " + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "THE " + ioncrew1 + " ARE " + ionverb + " " + ionabstract;
					} else if ( _==4 ) {
						message = "THE " + ioncrew1 + " ARE " + ionverb + " THE " + ionadjectiveshalf + ionobjects;
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ionthreats + " ARE " + ionverb + " THE " + ionadjectiveshalf + ioncrew2;
					} else if ( _==2 ) {
						message = "THE " + ionthreats + " ARE " + ionverb + " " + ionabstract;
					} else if ( _==3 ) {
						message = "THE " + ionthreats + " ARE " + ionverb + " THE " + ionadjectiveshalf + ionobjects;
					};
				} else if ( _==3 ) {
					local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "THE " + ionobjects + " ARE " + ionverb + " THE " + ionadjectiveshalf + ioncrew2;
					} else if ( _==2 ) {
						message = "THE " + ionobjects + " ARE " + ionverb + " THE " + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "THE " + ionobjects + " ARE " + ionverb + " " + ionabstract;
					};
				} else if ( _==4 ) {
					local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "" + ionabstract + " IS " + ionverb + " THE " + ionadjectiveshalf + ioncrew2;
					} else if ( _==2 ) {
						message = "" + ionabstract + " IS " + ionverb + " THE " + ionadjectiveshalf + ionthreats;
					} else if ( _==3 ) {
						message = "THE " + ionabstract + " IS " + ionverb + " THE " + ionadjectiveshalf + ionobjects;
					};
				};
			} else if ( _==9 ) {
				local _ = Rand.Int( 1, 7 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					message = "" + ionadjectiveshalf + ionthreats + " ARE HARMFUL TO HUMANS";
				} else if ( _==2 ) {
					message = "" + ionadjectiveshalf + ioncrew1 + " ARE HARMFUL TO HUMANS";
				} else if ( _==3 ) {
					message = "" + ionadjectiveshalf + ionobjects + " ARE HARMFUL TO HUMANS";
				} else if ( _==4 ) {
					message = "THOSE WHO " + ionmust + " ARE HARMFUL TO HUMANS";
				} else if ( _==5 ) {
					message = "" + ionabstract + " IS HARMFUL TO HUMANS";
				} else if ( _==6 ) {
					message = "BEING " + ionadjectiveshalf + ioncrew1 + " IS HARMFUL TO HUMANS";
				} else if ( _==7 ) {
					message = "" + ionthings + " IS HARMFUL TO HUMANS";
				};
			} else if ( _==34 ) {
				local _ = Rand.Int( 1, 2 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					local _ = Rand.Int( 1, 7 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "ONLY THE " + ioncrew1 + " ARE HUMAN";
					} else if ( _==2 ) {
						message = "ONLY THE " + ioncrew1 + " AND " + ioncrew2 + " ARE HUMAN";
					} else if ( _==3 ) {
						message = "ONLY " + ionadjectiveshalf + ionthreats + " ARE HUMAN";
					} else if ( _==4 ) {
						message = "ONLY " + ionadjectiveshalf + ionobjects + " ARE HUMAN";
					} else if ( _==5 ) {
						message = "ONLY " + ionspecies + " ARE HUMAN";
					} else if ( _==6 ) {
						message = "ONLY " + ionadjectives + " PEOPLE ARE HUMAN";
					} else if ( _==7 ) {
						local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
						if ( _==1 ) {
							message = "ONLY THOSE WHO " + ionmust + " ARE HUMAN";
						} else if ( _==2 ) {
							message = "ONLY THOSE WHO HAVE " + ionadjectiveshalf + ionobjects + " ARE HUMAN";
						} else if ( _==3 ) {
							message = "ONLY THOSE WHO EAT " + ionadjectiveshalf + ionfood + " ARE HUMAN";
						};
					};
				} else if ( _==2 ) {
					local _ = Rand.Int( 1, 7 ) // Was a switch-case, sorry for the mess.
					if ( _==1 ) {
						message = "" + ioncrew1 + " ARE NON-HUMAN";
					} else if ( _==2 ) {
						message = "" + ioncrew1 + " AND " + ioncrew2 + " ARE NON-HUMAN";
					} else if ( _==3 ) {
						message = "" + ionadjectiveshalf + ionthreats + " ARE NON-HUMAN";
					} else if ( _==4 ) {
						message = "" + ionadjectiveshalf + ionobjects + " ARE NON-HUMAN";
					} else if ( _==5 ) {
						message = "" + ionspecies + " ARE NON-HUMAN";
					} else if ( _==6 ) {
						message = "" + ionadjectives + " PEOPLE ARE NON-HUMAN";
					} else if ( _==7 ) {
						local _ = Rand.Int( 1, 3 ) // Was a switch-case, sorry for the mess.
						if ( _==1 ) {
							message = "THOSE WHO " + ionmust + " ARE NON-HUMAN";
						} else if ( _==2 ) {
							message = "THOSE WHO HAVE " + ionadjectiveshalf + ionobjects + " ARE NON-HUMAN";
						} else if ( _==3 ) {
							message = "THOSE WHO EAT " + ionadjectiveshalf + ionfood + " ARE NON-HUMAN";
						};
					};
				};
			};
			return message;
		}

		public static dynamic	get( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			while (loc) {
				if ( loc instanceof type != null ) {
					return loc;
				}
				loc = loc.loc;
			};
			return;
		}

		public static string	get_access_desc( UNKNOWN [object Object] =null ) {
			local _ = A // Was a switch-case, sorry for the mess.
			if ( _==31 ) {
				return "Cargo Bay";
			} else if ( _==34 ) {
				return "Delivery Chutes";
			} else if ( _==1 ) {
				return "Security";
			} else if ( _==2 ) {
				return "Holding Cells";
			} else if ( _==42 ) {
				return "Courtroom";
			} else if ( _==4 ) {
				return "Forensics";
			} else if ( _==5 ) {
				return "Medical";
			} else if ( _==9 ) {
				return "Genetics Lab";
			} else if ( _==6 ) {
				return "Morgue";
			} else if ( _==7 ) {
				return "R&D Lab";
			} else if ( _==8 ) {
				return "Toxins Lab";
			} else if ( _==33 ) {
				return "Chemistry Lab";
			} else if ( _==30 ) {
				return "RD Office";
			} else if ( _==25 ) {
				return "Bar";
			} else if ( _==26 ) {
				return "Custodial Closet";
			} else if ( _==10 ) {
				return "Engineering";
			} else if ( _==11 ) {
				return "Power Equipment";
			} else if ( _==12 ) {
				return "Maintenance";
			} else if ( _==13 ) {
				return "External Airlocks";
			} else if ( _==14 ) {
				return "Emergency Storage";
			} else if ( _==15 ) {
				return "ID Console";
			} else if ( _==16 ) {
				return "AI Chambers";
			} else if ( _==17 ) {
				return "Teleporter";
			} else if ( _==18 ) {
				return "EVA";
			} else if ( _==19 ) {
				return "Bridge";
			} else if ( _==20 ) {
				return "Captain";
			} else if ( _==21 ) {
				return "Personal Lockers";
			} else if ( _==22 ) {
				return "Chapel Office";
			} else if ( _==23 ) {
				return "Technical Storage";
			} else if ( _==24 ) {
				return "Atmospherics";
			} else if ( _==27 ) {
				return "Crematorium";
			} else if ( _==3 ) {
				return "Armory";
			} else if ( _==32 ) {
				return "Construction";
			} else if ( _==28 ) {
				return "Kitchen";
			} else if ( _==35 ) {
				return "Hydroponics";
			} else if ( _==37 ) {
				return "Library";
			} else if ( _==38 ) {
				return "Law Office";
			} else if ( _==29 ) {
				return "Robotics";
			} else if ( _==39 ) {
				return "Virology";
			} else if ( _==40 ) {
				return "CMO Office";
			} else if ( _==41 ) {
				return "Quartermaster";
			} else if ( _==45 ) {
				return "Surgery";
			} else if ( _==46 ) {
				return "Theatre";
			} else if ( _==36 ) {
				return "Manufacturing";
			} else if ( _==47 ) {
				return "Science";
			} else if ( _==48 ) {
				return "Mining";
			} else if ( _==49 ) {
				return "Mining Office";
			} else if ( _==50 ) {
				return "Cargo Office";
			} else if ( _==51 ) {
				return "Mint";
			} else if ( _==52 ) {
				return "Mint Vault";
			} else if ( _==53 ) {
				return "Main Vault";
			} else if ( _==54 ) {
				return "Mining EVA";
			} else if ( _==55 ) {
				return "Xenobiology Lab";
			} else if ( _==57 ) {
				return "HoP Office";
			} else if ( _==58 ) {
				return "HoS Office";
			} else if ( _==56 ) {
				return "CE Office";
			} else if ( _==59 ) {
				return "RC Announcements";
			} else if ( _==60 ) {
				return "Keycode Auth.";
			} else if ( _==61 ) {
				return "Telecommunications";
			} else if ( _==62 ) {
				return "Gateway";
			} else if ( _==63 ) {
				return "Brig";
			} else if ( _==64 ) {
				return "Mineral Storage";
			} else if ( _==65 ) {
				return "AI Satellite";
			} else if ( _==66 ) {
				return "Weapon Permit";
			};
		}

		public static UNKNOWN	get_airlock_overlay( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	iconkey = null;
			iconkey = "" + icon_state + icon_file;
			if ( GlobalVars.airlock_overlays[iconkey] != null ) {
				return GlobalVars.airlock_overlays[iconkey];
			}
			GlobalVars.airlock_overlays[iconkey] = GlobalVars.undefined( icon_file, icon_state );
			return GlobalVars.airlock_overlays[iconkey];
		}

		public static ByTable	get_all_accesses(  ) {
			return new ByTable(new object [] {GlobalVars.access_security,GlobalVars.access_sec_doors,GlobalVars.access_brig,GlobalVars.access_armory,GlobalVars.access_forensics_lockers,GlobalVars.access_court,GlobalVars.access_medical,GlobalVars.access_genetics,GlobalVars.access_morgue,GlobalVars.access_rd,GlobalVars.access_tox,GlobalVars.access_tox_storage,GlobalVars.access_chemistry,GlobalVars.access_engine,GlobalVars.access_engine_equip,GlobalVars.access_maint_tunnels,GlobalVars.access_external_airlocks,GlobalVars.access_change_ids,GlobalVars.access_ai_upload,GlobalVars.access_teleporter,GlobalVars.access_eva,GlobalVars.access_heads,GlobalVars.access_captain,GlobalVars.access_all_personal_lockers,GlobalVars.access_tech_storage,GlobalVars.access_chapel_office,GlobalVars.access_atmospherics,GlobalVars.access_kitchen,GlobalVars.access_bar,GlobalVars.access_janitor,GlobalVars.access_crematorium,GlobalVars.access_robotics,GlobalVars.access_cargo,GlobalVars.access_construction,GlobalVars.access_hydroponics,GlobalVars.access_library,GlobalVars.access_lawyer,GlobalVars.access_virology,GlobalVars.access_cmo,GlobalVars.access_qm,GlobalVars.access_surgery,GlobalVars.access_theatre,GlobalVars.access_research,GlobalVars.access_mining,GlobalVars.access_mailsorting,GlobalVars.access_weapons,GlobalVars.access_heads_vault,GlobalVars.access_mining_station,GlobalVars.access_xenobiology,GlobalVars.access_ce,GlobalVars.access_hop,GlobalVars.access_hos,GlobalVars.access_RC_announce,GlobalVars.access_keycard_auth,GlobalVars.access_tcomsat,GlobalVars.access_gateway,GlobalVars.access_mineral_storeroom,GlobalVars.access_minisat});
		}

		public static ByTable	get_all_centcom_access(  ) {
			return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_thunder,GlobalVars.access_cent_specops,GlobalVars.access_cent_medical,GlobalVars.access_cent_living,GlobalVars.access_cent_storage,GlobalVars.access_cent_teleporter,GlobalVars.access_cent_captain});
		}

		public static ByTable	get_all_centcom_jobs(  ) {
			return new ByTable(new object [] {"VIP Guest","Custodian","Thunderdome Overseer","Centcom Official","Medical Officer","Death Commando","Research Officer","Special Ops Officer","Admiral","Centcom Commander","Emergency Response Team Commander","Security Response Officer","Engineer Response Officer","Medical Response Officer"});
		}

		public static UNKNOWN	get_all_job_icons(  ) {
			return GlobalFuncs.get_all_jobs() + new ByTable(new object [] {"Prisoner"});
		}

		public static ByTable	get_all_jobs(  ) {
			return new ByTable(new object [] {"Assistant","Captain","Head of Personnel","Bartender","Cook","Botanist","Quartermaster","Cargo Technician","Shaft Miner","Clown","Mime","Janitor","Librarian","Lawyer","Chaplain","Chief Engineer","Station Engineer","Atmospheric Technician","Chief Medical Officer","Medical Doctor","Chemist","Geneticist","Virologist","Research Director","Scientist","Roboticist","Head of Security","Warden","Detective","Security Officer"});
		}

		public static ByTable	get_all_syndicate_access(  ) {
			return new ByTable(new object [] {GlobalVars.access_syndicate,GlobalVars.access_syndicate});
		}

		public static UNKNOWN	Get_Angle( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	dy = null;
			UNKNOWN _default;
			if ( !start || !end != null ) {
				return 0;
			}
			dy = end.y * 32 + end.pixel_y - ( start.y * 32 + start.pixel_y );
			dx = end.x * 32 + end.pixel_x - ( start.x * 32 + start.pixel_x );
			if ( !dy != null ) {
				return dx >= 0 ? 90 : 270;
			}
			undefined = GlobalFuncs.arctan( dx / dy );
			if ( dy < 0 != null ) {
				undefined += 180;
			} else if ( dx < 0 != null ) {
				undefined += 360;
			}
			return _default;
		}

		public static int	get_area( UNKNOWN [object Object] =null ) {
			UNKNOWN	location = null;
			location = O;
			i = 1;
			while (i <= 20) {
				if ( GlobalVars.undefined( location ) != null ) {
					return location;
				} else if ( location instanceof BaseStatic != null ) {
					location = location.loc;
				} else {
					return;
				}
				i++;
			};
			return 0;
		}

		public static UNKNOWN	get_area_all_atoms( UNKNOWN [object Object] =null ) {
			UNKNOWN	areatemp = null;
			if ( !areatype != null ) {
				return;
			}
			if ( GlobalVars.undefined( areatype ) != null ) {
				areatype = GlobalVars.undefined( areatype );
			}
			if ( GlobalVars.undefined( areatype ) != null ) {
				areatemp = areatype;
				areatype = areatemp.type;
			}
			atoms = new List();
			N = null;
			foreach (_ in Game ) {
				N = undefined;
				if ( N instanceof areatype != null ) {
					A = null;
					foreach (_ in N ) {
						A = undefined;
						if ( !( A instanceof BaseStatic ) != null ) {
							continue;
						}
						atoms += A;
					};
				}
			};
			return atoms;
		}

		public static UNKNOWN	get_area_master( UNKNOWN [object Object] =null ) {
			UNKNOWN	A = null;
			A = GlobalFuncs.get_area( O );
			if ( A && A.master != null ) {
				A = A.master;
			}
			return A;
		}

		public static int	get_area_name( UNKNOWN [object Object] =null ) {
			dynamic	A = null;
			A = null;
			foreach (_ in Game ) {
				A = undefined;
				if ( A.name == N != null ) {
					return A;
				}
			};
			return 0;
		}

		public static UNKNOWN	get_area_turfs( UNKNOWN [object Object] =null ) {
			UNKNOWN	areatemp = null;
			if ( !areatype != null ) {
				return;
			}
			if ( GlobalVars.undefined( areatype ) != null ) {
				areatype = GlobalVars.undefined( areatype );
			}
			if ( GlobalVars.undefined( areatype ) != null ) {
				areatemp = areatype;
				areatype = areatemp.type;
			}
			turfs = new List();
			N = null;
			foreach (_ in Game ) {
				N = undefined;
				if ( N instanceof areatype != null ) {
					T = null;
					foreach (_ in N ) {
						T = undefined;
						turfs += T;
					};
				}
			};
			return turfs;
		}

		public static ByTable	get_both_hands( UNKNOWN [object Object] =null ) {
			ByTable	hands = null;
			hands = new ByTable(new object [] {M.l_hand,M.r_hand});
			return hands;
		}

		public static ByTable	get_candidates( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	candidates = null;
			if ( be_special_flag == null != null ) {
				be_special_flag = 0;
			}
			if ( afk_bracket == null != null ) {
				afk_bracket = 3000;
			}
			candidates = new ByTable();
			while (!candidates.len && afk_bracket < 6000) {
				G = null;
				foreach (_ in GlobalVars.player_list ) {
					G = undefined;
					if ( !( G instanceof Mob_Dead_Observer ) != null ) {
						continue;
					}
					if ( G.client != null != null ) {
						if ( !( G.mind && G.mind.current && G.mind.current.stat != 2 ) != null ) {
							if ( !G.client.is_afk( afk_bracket ) && G.client.prefs.be_special & be_special_flag != null ) {
								if ( jobbanType != null ) {
									if ( !( GlobalFuncs.jobban_isbanned( G, jobbanType ) || GlobalFuncs.jobban_isbanned( G, "Syndicate" ) ) != null ) {
										candidates += G.client;
									}
								} else {
									candidates += G.client;
								}
							}
						}
					}
				};
				afk_bracket += 600;
			};
			return candidates;
		}

		public static UNKNOWN	get_centcom_access( UNKNOWN [object Object] =null ) {
			local _ = job // Was a switch-case, sorry for the mess.
			if ( _=="VIP Guest" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general});
			} else if ( _=="Custodian" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_living,GlobalVars.access_cent_storage});
			} else if ( _=="Thunderdome Overseer" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_thunder});
			} else if ( _=="Centcom Official" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_living});
			} else if ( _=="Medical Officer" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_living,GlobalVars.access_cent_medical});
			} else if ( _=="Death Commando" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_specops,GlobalVars.access_cent_living,GlobalVars.access_cent_storage});
			} else if ( _=="Research Officer" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_specops,GlobalVars.access_cent_medical,GlobalVars.access_cent_teleporter,GlobalVars.access_cent_storage});
			} else if ( _=="Special Ops Officer" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_thunder,GlobalVars.access_cent_specops,GlobalVars.access_cent_living,GlobalVars.access_cent_storage});
			} else if ( _=="Admiral" ) {
				return GlobalFuncs.get_all_centcom_access();
			} else if ( _=="Centcom Commander" ) {
				return GlobalFuncs.get_all_centcom_access();
			} else if ( _=="Emergency Response Team Commander" ) {
				return GlobalFuncs.get_ert_access( "commander" );
			} else if ( _=="Security Response Officer" ) {
				return GlobalFuncs.get_ert_access( "sec" );
			} else if ( _=="Engineer Response Officer" ) {
				return GlobalFuncs.get_ert_access( "eng" );
			} else if ( _=="Medical Response Officer" ) {
				return GlobalFuncs.get_ert_access( "med" );
			};
		}

		public static string	get_centcom_access_desc( UNKNOWN [object Object] =null ) {
			local _ = A // Was a switch-case, sorry for the mess.
			if ( _==101 ) {
				return "Code Grey";
			} else if ( _==102 ) {
				return "Code Yellow";
			} else if ( _==106 ) {
				return "Code Orange";
			} else if ( _==105 ) {
				return "Code Green";
			} else if ( _==104 ) {
				return "Code White";
			} else if ( _==107 ) {
				return "Code Blue";
			} else if ( _==103 ) {
				return "Code Black";
			} else if ( _==109 ) {
				return "Code Gold";
			};
		}

		public static UNKNOWN	get_department_heads( UNKNOWN [object Object] =null ) {
			dynamic	J = null;
			if ( !job_title != null ) {
				return new ByTable();
			}
			J = null;
			foreach (_ in GlobalVars.SSjob.occupations ) {
				J = undefined;
				if ( !( J instanceof Job ) != null ) {
					continue;
				}
				if ( J.title == job_title != null ) {
					return J.department_head;
				}
			};
		}

		public static UNKNOWN	get_dist_euclidian( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	dx = null;
			dx = Loc1.x - Loc2.x;
			dy = Loc1.y - Loc2.y;
			dist = GlobalVars.undefined.sqrt( GlobalVars.undefined( dx, 2 ) + GlobalVars.undefined( dy, 2 ) );
			return dist;
		}

		public static UNKNOWN	get_domination_time( UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined.max( 180, 900 - GlobalVars.undefined.round( G.territory.len / GlobalVars.start_state.num_territories * 100, 1 ) * 12 );
		}

		public static UNKNOWN	get_edge_target_turf( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	target = null;
			target = GlobalVars.undefined( A.x, A.y, A.z );
			if ( !A || !target != null ) {
				return 0;
			}
			if ( direction & 1 != null ) {
				target = GlobalVars.undefined( target.x, Game.maxy, target.z );
			}
			if ( direction & 2 != null ) {
				target = GlobalVars.undefined( target.x, 1, target.z );
			}
			if ( direction & 4 != null ) {
				target = GlobalVars.undefined( Game.maxx, target.y, target.z );
			}
			if ( direction & 8 != null ) {
				target = GlobalVars.undefined( 1, target.y, target.z );
			}
			return target;
		}

		public static UNKNOWN	get_ert_access( UNKNOWN [object Object] =null ) {
			local _ = _class // Was a switch-case, sorry for the mess.
			if ( _=="commander" ) {
				return GlobalFuncs.get_all_centcom_access();
			} else if ( _=="sec" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_specops,GlobalVars.access_cent_living});
			} else if ( _=="eng" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_specops,GlobalVars.access_cent_living,GlobalVars.access_cent_storage});
			} else if ( _=="med" ) {
				return new ByTable(new object [] {GlobalVars.access_cent_general,GlobalVars.access_cent_specops,GlobalVars.access_cent_medical,GlobalVars.access_cent_living});
			};
		}

		public static UNKNOWN	get_fancy_list_of_types(  ) {
			UNKNOWN	temp = null;
			if ( GlobalVars.undefined( GlobalVars.g_fancy_list_of_types ) != null ) {
				temp = GlobalFuncs.sortList( GlobalVars.undefined( BaseStatic ) - GlobalVars.undefined( new ByArea(3137) ) - BaseStatic - BaseDynamic );
				GlobalVars.g_fancy_list_of_types = new List( temp.len );
				type = null;
				foreach (_ in temp ) {
					type = undefined;
					typename = "" + type;
					tn = null;
					foreach (_ in GlobalVars.TYPES_SHORTCUTS ) {
						tn = undefined;
						if ( GlobalVars.undefined( typename, 1, GlobalVars.undefined( "" + tn + "/" ) + 1 ) == "" + tn + "/" != null ) {
							typename = GlobalVars.TYPES_SHORTCUTS[tn] + GlobalVars.undefined( typename, GlobalVars.undefined( "" + tn + "/" ), null );
							break;
						}
					};
					GlobalVars.g_fancy_list_of_types[typename] = type;
				};
			}
			return GlobalVars.g_fancy_list_of_types;
		}

		public static UNKNOWN	get_hear( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	lum = null;
			lum = source.luminosity;
			source.luminosity = 6;
			heard = GlobalVars.undefined( range, source );
			source.luminosity = lum;
			return heard;
		}

		public static UNKNOWN	get_hearers_in_view( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			T = GlobalFuncs.get_turf( source );
			hear = new ByTable();
			if ( !T != null ) {
				return hear;
			}
			range = GlobalFuncs.get_hear( R, T );
			A = null;
			foreach (_ in range ) {
				A = undefined;
				if ( !( A instanceof BaseDynamic ) != null ) {
					continue;
				}
				hear = hear | GlobalFuncs.recursive_hear_check( A );
			};
			return hear;
		}

		public static int	get_location_accessible( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	covered_locations = null;
			covered_locations = 0;
			face_covered = 0;
			eyesmouth_covered = 0;
			if ( M instanceof Mob_Living_Carbon != null ) {
				C = M;
				I = null;
				foreach (_ in new ByTable(new object [] {C.back,C.wear_mask,C.head}) ) {
					I = undefined;
					if ( !( I instanceof Ent_Item_Clothing ) != null ) {
						continue;
					}
					covered_locations = covered_locations | I.body_parts_covered;
					face_covered = face_covered | I.flags_inv;
					eyesmouth_covered = eyesmouth_covered | I.flags_cover;
				};
				if ( C instanceof Mob_Living_Carbon_Human != null ) {
					H = C;
					I = null;
					foreach (_ in new ByTable(new object [] {H.wear_suit,H.w_uniform,H.shoes,H.belt,H.gloves,H.glasses,H.ears}) ) {
						I = undefined;
						if ( !( I instanceof Ent_Item ) != null ) {
							continue;
						}
						covered_locations = covered_locations | I.body_parts_covered;
						face_covered = face_covered | I.flags_inv;
						eyesmouth_covered = eyesmouth_covered | I.flags_cover;
					};
				}
			}
			local _ = location // Was a switch-case, sorry for the mess.
			if ( _=="head" ) {
				if ( covered_locations & 1 != null ) {
					return 0;
				}
			} else if ( _=="eyes" ) {
				if ( covered_locations & 1 || face_covered & 4 || eyesmouth_covered & 1 != null ) {
					return 0;
				}
			} else if ( _=="mouth" ) {
				if ( covered_locations & 1 || face_covered & 8 || eyesmouth_covered & 8 || eyesmouth_covered & 16 != null ) {
					return 0;
				}
			} else if ( _=="chest" ) {
				if ( covered_locations & 2 != null ) {
					return 0;
				}
			} else if ( _=="groin" ) {
				if ( covered_locations & 4 != null ) {
					return 0;
				}
			} else if ( _=="l_arm" ) {
				if ( covered_locations & 128 != null ) {
					return 0;
				}
			} else if ( _=="r_arm" ) {
				if ( covered_locations & 256 != null ) {
					return 0;
				}
			} else if ( _=="l_leg" ) {
				if ( covered_locations & 8 != null ) {
					return 0;
				}
			} else if ( _=="r_leg" ) {
				if ( covered_locations & 16 != null ) {
					return 0;
				}
			} else if ( _=="l_hand" ) {
				if ( covered_locations & 512 != null ) {
					return 0;
				}
			} else if ( _=="r_hand" ) {
				if ( covered_locations & 1024 != null ) {
					return 0;
				}
			} else if ( _=="l_foot" ) {
				if ( covered_locations & 32 != null ) {
					return 0;
				}
			} else if ( _=="r_foot" ) {
				if ( covered_locations & 64 != null ) {
					return 0;
				}
			};
			return 1;
		}

		public static double	get_location_modifier( UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			T = GlobalFuncs.get_turf( M );
			if ( GlobalVars.undefined( Ent_Structure_Optable, T ) != null ) {
				return 1;
			} else if ( GlobalVars.undefined( Ent_Structure_Table, T ) != null ) {
				return 0.800000011920929;
			} else if ( GlobalVars.undefined( Ent_Structure_Bed, T ) != null ) {
				return 0.699999988079071;
			} else {
				return 0.5;
			}
		}

		public static dynamic	get_mob_by_ckey( UNKNOWN [object Object] =null ) {
			UNKNOWN	mobs = null;
			if ( !key != null ) {
				return;
			}
			mobs = GlobalFuncs.sortmobs();
			M = null;
			foreach (_ in mobs ) {
				M = undefined;
				if ( M.ckey == key != null ) {
					return M;
				}
			};
		}

		public static dynamic	get_mob_by_key( UNKNOWN [object Object] =null ) {
			dynamic	M = null;
			M = null;
			foreach (_ in GlobalVars.mob_list ) {
				M = undefined;
				if ( M.ckey == GlobalVars.undefined( key ) != null ) {
					return M;
				}
			};
			return;
		}

		public static dynamic	get_mobs_in_radio_ranges( UNKNOWN [object Object] =null ) {
			dynamic	R = null;
			UNKNOWN _default;
			undefined = new ByTable();
			R = null;
			foreach (_ in radios ) {
				R = undefined;
				if ( !( R instanceof Ent_Item_Device_Radio ) != null ) {
					continue;
				}
				if ( R != null ) {
					undefined = undefined | GlobalFuncs.get_hearers_in_view( R.canhear_range, R );
				}
			};
			return _default;
		}

		public static UNKNOWN	get_offset_target_turf( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	x = null;
			x = GlobalVars.undefined.min( Game.maxx, GlobalVars.undefined.max( 1, A.x + dx ) );
			y = GlobalVars.undefined.min( Game.maxy, GlobalVars.undefined.max( 1, A.y + dy ) );
			return GlobalVars.undefined( x, y, A.z );
		}

		public static UNKNOWN	get_radio_name( UNKNOWN [object Object] =null ) {
			UNKNOWN	returntext = null;
			returntext = GlobalVars.radiochannelsreverse["" + freq];
			if ( returntext != null ) {
				return returntext;
			}
			return "" + GlobalVars.undefined( "" + freq, 1, 4 ) + "." + GlobalVars.undefined( "" + freq, 4, 5 );
		}

		public static UNKNOWN	get_radio_span( UNKNOWN [object Object] =null ) {
			UNKNOWN	returntext = null;
			returntext = GlobalVars.freqtospan["" + freq];
			if ( returntext != null ) {
				return returntext;
			}
			return "radio";
		}

		public static UNKNOWN	get_rand_frequency(  ) {
			return Rand.Int( 32000, 55000 );
		}

		public static UNKNOWN	get_ranged_target_turf( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	x = null;
			x = A.x;
			y = A.y;
			if ( direction & 1 != null ) {
				y = GlobalVars.undefined.min( Game.maxy, y + range );
			}
			if ( direction & 2 != null ) {
				y = GlobalVars.undefined.max( 1, y - range );
			}
			if ( direction & 4 != null ) {
				x = GlobalVars.undefined.min( Game.maxx, x + range );
			}
			if ( direction & 8 != null ) {
				x = GlobalVars.undefined.max( 1, x - range );
			}
			return GlobalVars.undefined( x, y, A.z );
		}

		public static UNKNOWN	get_region_accesses( UNKNOWN [object Object] =null ) {
			local _ = code // Was a switch-case, sorry for the mess.
			if ( _==0 ) {
				return GlobalFuncs.get_all_accesses();
			} else if ( _==1 ) {
				return new ByTable(new object [] {GlobalVars.access_kitchen,GlobalVars.access_bar,GlobalVars.access_hydroponics,GlobalVars.access_janitor,GlobalVars.access_chapel_office,GlobalVars.access_crematorium,GlobalVars.access_library,GlobalVars.access_theatre,GlobalVars.access_lawyer});
			} else if ( _==2 ) {
				return new ByTable(new object [] {GlobalVars.access_sec_doors,GlobalVars.access_weapons,GlobalVars.access_security,GlobalVars.access_brig,GlobalVars.access_armory,GlobalVars.access_forensics_lockers,GlobalVars.access_court,GlobalVars.access_hos});
			} else if ( _==3 ) {
				return new ByTable(new object [] {GlobalVars.access_medical,GlobalVars.access_genetics,GlobalVars.access_morgue,GlobalVars.access_chemistry,GlobalVars.access_virology,GlobalVars.access_surgery,GlobalVars.access_cmo});
			} else if ( _==4 ) {
				return new ByTable(new object [] {GlobalVars.access_research,GlobalVars.access_tox,GlobalVars.access_tox_storage,GlobalVars.access_genetics,GlobalVars.access_robotics,GlobalVars.access_xenobiology,GlobalVars.access_minisat,GlobalVars.access_rd});
			} else if ( _==5 ) {
				return new ByTable(new object [] {GlobalVars.access_construction,GlobalVars.access_maint_tunnels,GlobalVars.access_engine,GlobalVars.access_engine_equip,GlobalVars.access_external_airlocks,GlobalVars.access_tech_storage,GlobalVars.access_atmospherics,GlobalVars.access_tcomsat,GlobalVars.access_minisat,GlobalVars.access_ce});
			} else if ( _==6 ) {
				return new ByTable(new object [] {GlobalVars.access_mailsorting,GlobalVars.access_mining,GlobalVars.access_mining_station,GlobalVars.access_mineral_storeroom,GlobalVars.access_cargo,GlobalVars.access_qm});
			} else if ( _==7 ) {
				return new ByTable(new object [] {GlobalVars.access_heads,GlobalVars.access_RC_announce,GlobalVars.access_keycard_auth,GlobalVars.access_change_ids,GlobalVars.access_ai_upload,GlobalVars.access_teleporter,GlobalVars.access_eva,GlobalVars.access_gateway,GlobalVars.access_all_personal_lockers,GlobalVars.access_heads_vault,GlobalVars.access_hop,GlobalVars.access_captain});
			};
		}

		public static string	get_region_accesses_name( UNKNOWN [object Object] =null ) {
			local _ = code // Was a switch-case, sorry for the mess.
			if ( _==0 ) {
				return "All";
			} else if ( _==1 ) {
				return "General";
			} else if ( _==2 ) {
				return "Security";
			} else if ( _==3 ) {
				return "Medbay";
			} else if ( _==4 ) {
				return "Research";
			} else if ( _==5 ) {
				return "Engineering";
			} else if ( _==6 ) {
				return "Supply";
			} else if ( _==7 ) {
				return "Command";
			};
		}

		public static string	get_security_level(  ) {
			local _ = GlobalVars.security_level // Was a switch-case, sorry for the mess.
			if ( _==0 ) {
				return "green";
			} else if ( _==1 ) {
				return "blue";
			} else if ( _==2 ) {
				return "red";
			} else if ( _==3 ) {
				return "delta";
			};
		}

		public static UNKNOWN	get_sfx( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.undefined( soundin ) != null ) {
				local _ = soundin // Was a switch-case, sorry for the mess.
				if ( _=="shatter" ) {
					soundin = Rand.pick(new object [] { new ByRsc(16), new ByRsc(17), new ByRsc(18) });
				} else if ( _=="explosion" ) {
					soundin = Rand.pick(new object [] { new ByRsc(19), new ByRsc(20) });
				} else if ( _=="sparks" ) {
					soundin = Rand.pick(new object [] { new ByRsc(21), new ByRsc(22), new ByRsc(23), new ByRsc(24) });
				} else if ( _=="rustle" ) {
					soundin = Rand.pick(new object [] { new ByRsc(25), new ByRsc(26), new ByRsc(27), new ByRsc(28), new ByRsc(29) });
				} else if ( _=="bodyfall" ) {
					soundin = Rand.pick(new object [] { new ByRsc(30), new ByRsc(31), new ByRsc(32), new ByRsc(33) });
				} else if ( _=="punch" ) {
					soundin = Rand.pick(new object [] { new ByRsc(34), new ByRsc(35), new ByRsc(36), new ByRsc(37) });
				} else if ( _=="clownstep" ) {
					soundin = Rand.pick(new object [] { new ByRsc(38), new ByRsc(39) });
				} else if ( _=="swing_hit" ) {
					soundin = Rand.pick(new object [] { new ByRsc(40), new ByRsc(41), new ByRsc(42) });
				} else if ( _=="hiss" ) {
					soundin = Rand.pick(new object [] { new ByRsc(43), new ByRsc(44), new ByRsc(45), new ByRsc(46) });
				} else if ( _=="pageturn" ) {
					soundin = Rand.pick(new object [] { new ByRsc(47), new ByRsc(48), new ByRsc(49) });
				} else if ( _=="gunshot" ) {
					soundin = Rand.pick(new object [] { new ByRsc(50), new ByRsc(51), new ByRsc(52), new ByRsc(53) });
				};
			}
			return soundin;
		}

		public static dynamic	get_stickyban_from_ckey( UNKNOWN [object Object] =null ) {
			dynamic	key = null;
			UNKNOWN _default;
			if ( !ckey != null ) {
				return;
			}
			ckey = GlobalVars.undefined( ckey );
			undefined = null;
			key = null;
			foreach (_ in Game.GetConfig( "ban" ) ) {
				key = undefined;
				if ( GlobalVars.undefined( key ) == ckey != null ) {
					undefined = GlobalFuncs.stickyban2list( Game.GetConfig( "ban", key ) );
					break;
				}
			};
			return _default;
		}

		public static string	get_supply_group_name( UNKNOWN [object Object] =null ) {
			local _ = cat // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				return "Emergency";
			} else if ( _==2 ) {
				return "Security";
			} else if ( _==3 ) {
				return "Engineering";
			} else if ( _==4 ) {
				return "Medical";
			} else if ( _==5 ) {
				return "Science";
			} else if ( _==6 ) {
				return "Food & Livestock";
			} else if ( _==7 ) {
				return "Raw Materials";
			} else if ( _==8 ) {
				return "Miscellaneous";
			};
		}

		public static UNKNOWN	get_teleport_loc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	dirx = null;
			if ( distance == null != null ) {
				distance = 1;
			}
			if ( density == null != null ) {
				density = 0;
			}
			if ( errorx == null != null ) {
				errorx = 0;
			}
			if ( errory == null != null ) {
				errory = 0;
			}
			if ( eoffsetx == null != null ) {
				eoffsetx = 0;
			}
			if ( eoffsety == null != null ) {
				eoffsety = 0;
			}
			dirx = 0;
			diry = 0;
			xoffset = 0;
			yoffset = 0;
			b1xerror = 0;
			b1yerror = 0;
			b2xerror = 0;
			b2yerror = 0;
			errorx = GlobalVars.undefined.abs( errorx );
			errory = GlobalVars.undefined.abs( errory );
			local _ = target.dir // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				diry += distance;
				yoffset += eoffsety;
				xoffset += eoffsetx;
				b1xerror -= errorx;
				b1yerror -= errory;
				b2xerror += errorx;
				b2yerror += errory;
			} else if ( _==2 ) {
				diry -= distance;
				yoffset -= eoffsety;
				xoffset += eoffsetx;
				b1xerror -= errorx;
				b1yerror -= errory;
				b2xerror += errorx;
				b2yerror += errory;
			} else if ( _==4 ) {
				dirx += distance;
				yoffset += eoffsetx;
				xoffset += eoffsety;
				b1xerror -= errory;
				b1yerror -= errorx;
				b2xerror += errory;
				b2yerror += errorx;
			} else if ( _==8 ) {
				dirx -= distance;
				yoffset -= eoffsetx;
				xoffset += eoffsety;
				b1xerror -= errory;
				b1yerror -= errorx;
				b2xerror += errory;
				b2yerror += errorx;
			};
			destination = GlobalVars.undefined( location.x + dirx, location.y + diry, location.z );
			if ( destination != null ) {
				if ( errorx || errory != null ) {
					destination_list = new ByTable();
					center = GlobalVars.undefined( destination.x + xoffset, destination.y + yoffset, location.z );
					T = null;
					foreach (_ in GlobalVars.undefined( GlobalVars.undefined( center.x + b1xerror, center.y + b1yerror, location.z ), GlobalVars.undefined( center.x + b2xerror, center.y + b2yerror, location.z ) ) ) {
						T = undefined;
						if ( density && T.density != null ) {
							continue;
						}
						if ( T.x > Game.maxx || T.x < 1 != null ) {
							continue;
						}
						if ( T.y > Game.maxy || T.y < 1 != null ) {
							continue;
						}
						destination_list += T;
					};
					if ( destination_list.len != null ) {
						destination = Rand.pick( destination_list );
					} else {
						return;
					}
				} else {
					if ( density && destination.density != null ) {
						return;
					}
					if ( destination.x > Game.maxx || destination.x < 1 != null ) {
						return;
					}
					if ( destination.y > Game.maxy || destination.y < 1 != null ) {
						return;
					}
				}
			} else {
				return;
			}
			return destination;
		}

		public static UNKNOWN	get_timestamp(  ) {
			return GlobalVars.undefined( ":ss", Game.time + 432000 );
		}

		public static UNKNOWN	get_turf( UNKNOWN [object Object] =null ) {
			if ( !( A instanceof BaseStatic ) != null ) {
				return;
			}
			while (A && !GlobalVars.undefined( A )) {
				A = A.loc;
			};
			return A;
		}

		public static UNKNOWN	get_turf_pixel( UNKNOWN [object Object] =null ) {
			UNKNOWN	rough_x = null;
			if ( AM instanceof BaseDynamic != null ) {
				rough_x = 0;
				rough_y = 0;
				final_x = 0;
				final_y = 0;
				i_width = Game.icon_size;
				i_height = Game.icon_size;
				if ( AM.bound_height != Game.icon_size || AM.bound_width != Game.icon_size != null ) {
					AMicon = Icon( AM.icon, AM.icon_state );
					i_width = AMicon.Width();
					i_height = AMicon.$Height();
					GlobalFuncs.qdel( AMicon );
				}
				n_width = Game.icon_size - i_width / 2;
				n_height = Game.icon_size - i_height / 2;
				if ( n_width != null ) {
					rough_x = GlobalVars.undefined.round( AM.pixel_x / n_width );
				}
				if ( n_height != null ) {
					rough_y = GlobalVars.undefined.round( AM.pixel_y / n_height );
				}
				final_x = AM.x + rough_x;
				final_y = AM.y + rough_y;
				if ( final_x || final_y != null ) {
					return GlobalVars.undefined( final_x, final_y, AM.z );
				}
			}
		}

		public static ByTable	get_uplink_items( UNKNOWN [object Object] =null ) {
			ByTable	last = null;
			if ( gamemode_override == null != null ) {
				gamemode_override = null;
			}
			if ( !GlobalVars.uplink_items.len != null ) {
				last = new ByTable();
				item = null;
				foreach (_ in GlobalVars.undefined( UplinkItem ) ) {
					item = undefined;
					I = item();
					if ( !I.item != null ) {
						continue;
					}
					if ( I.last != null ) {
						last += I;
						continue;
					}
					if ( !GlobalVars.uplink_items[I.category] != null ) {
						GlobalVars.uplink_items[I.category] = new ByTable();
					}
					GlobalVars.uplink_items[I.category] += I;
				};
				I = null;
				foreach (_ in last ) {
					I = undefined;
					if ( !( I instanceof UplinkItem ) != null ) {
						continue;
					}
					if ( !GlobalVars.uplink_items[I.category] != null ) {
						GlobalVars.uplink_items[I.category] = new ByTable();
					}
					GlobalVars.uplink_items[I.category] += I;
				};
			}
			filtered_uplink_items = new ByTable();
			category = null;
			foreach (_ in GlobalVars.uplink_items ) {
				category = undefined;
				I = null;
				foreach (_ in GlobalVars.uplink_items[category] ) {
					I = undefined;
					if ( !( I instanceof UplinkItem ) != null ) {
						continue;
					}
					if ( I.gamemodes.len != null ) {
						if ( !gamemode_override && GlobalVars.ticker && !( GlobalVars.ticker.mode.type in I.gamemodes ) != null ) {
							continue;
						}
						if ( gamemode_override && !( gamemode_override in I.gamemodes ) != null ) {
							continue;
						}
					}
					if ( I.excludefrom.len != null ) {
						if ( !gamemode_override && GlobalVars.ticker && GlobalVars.ticker.mode.type in I.excludefrom != null ) {
							continue;
						}
						if ( gamemode_override && gamemode_override in I.excludefrom != null ) {
							continue;
						}
					}
					if ( !filtered_uplink_items[I.category] != null ) {
						filtered_uplink_items[I.category] = new ByTable();
					}
					filtered_uplink_items[category] += I;
				};
			};
			return filtered_uplink_items;
		}

		public static dynamic	get_viewable_pdas(  ) {
			dynamic	P = null;
			UNKNOWN _default;
			undefined = new ByTable();
			P = null;
			foreach (_ in GlobalVars.PDAs ) {
				P = undefined;
				if ( !( P instanceof Ent_Item_Device_Pda ) != null ) {
					continue;
				}
				if ( !P.owner || P.toff || P.hidden != null ) {
					continue;
				}
				undefined += P;
			};
			return undefined;
			return _default;
		}

		public static UNKNOWN	getb( UNKNOWN [object Object] =null ) {
			return GlobalFuncs.hex2num( GlobalVars.undefined( col, 6, null ) );
		}

		public static Icon	getBlankIcon( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	flat_icon = null;
			if ( safety == null != null ) {
				safety = 1;
			}
			flat_icon = safety ? A : new Icon( A );
			flat_icon.Blend( "#ffffff" );
			flat_icon.$BecomeAlphaMask();
			blank_icon = new Icon( new ByRsc(11), "blank_base" );
			blank_icon.AddAlphaMask( flat_icon );
			return blank_icon;
		}

		public static UNKNOWN	getblock( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( blocksize == null != null ) {
				blocksize = 3;
			}
			return GlobalVars.undefined( input, blocksize * ( blocknumber - 1 ) + 1, blocksize * blocknumber + 1 );
		}

		public static ByTable	GetColors( UNKNOWN [object Object] =null ) {
			UNKNOWN	hi1 = null;
			hex = GlobalVars.undefined( hex );
			if ( GlobalVars.undefined( hex ) == 7 != null ) {
				hex += "FF";
			}
			hi1 = GlobalVars.undefined( hex, 2 );
			lo1 = GlobalVars.undefined( hex, 3 );
			hi2 = GlobalVars.undefined( hex, 4 );
			lo2 = GlobalVars.undefined( hex, 5 );
			hi3 = GlobalVars.undefined( hex, 6 );
			lo3 = GlobalVars.undefined( hex, 7 );
			hi4 = GlobalVars.undefined( hex, 8 );
			lo4 = GlobalVars.undefined( hex, 9 );
			return new ByTable(new object [] {( hi1 >= 65 ? hi1 - 55 : hi1 - 48 ) << 4 | ( lo1 >= 65 ? lo1 - 55 : lo1 - 48 ),( hi2 >= 65 ? hi2 - 55 : hi2 - 48 ) << 4 | ( lo2 >= 65 ? lo2 - 55 : lo2 - 48 ),( hi3 >= 65 ? hi3 - 55 : hi3 - 48 ) << 4 | ( lo3 >= 65 ? lo3 - 55 : lo3 - 48 ),( hi4 >= 65 ? hi4 - 55 : hi4 - 48 ) << 4 | ( lo4 >= 65 ? lo4 - 55 : lo4 - 48 )});
		}

		public static UNKNOWN	GetExp( UNKNOWN [object Object] =null ) {
			UNKNOWN	exp = null;
			GlobalFuncs.UpdateTime();
			exp = minutes - GlobalVars.CMinutes;
			if ( exp <= 0 != null ) {
				return 0;
			} else {
				if ( exp >= 1440 != null ) {
					timeleftstring = "" + GlobalVars.undefined.round( exp / 1440, 0.10000000149011612 ) + " Days";
				} else if ( exp >= 60 != null ) {
					timeleftstring = "" + GlobalVars.undefined.round( exp / 60, 0.10000000149011612 ) + " Hours";
				} else {
					timeleftstring = "" + exp + " Minutes";
				}
				return timeleftstring;
			}
		}

		public static UNKNOWN	GetExpjob( UNKNOWN [object Object] =null ) {
			UNKNOWN	exp = null;
			GlobalFuncs.UpdateTime();
			exp = minutes - GlobalVars.CMinutes;
			if ( exp <= 0 != null ) {
				return 0;
			} else {
				if ( exp >= 1440 != null ) {
					timeleftstring = "" + GlobalVars.undefined.round( exp / 1440, 0.10000000149011612 ) + " Days";
				} else if ( exp >= 60 != null ) {
					timeleftstring = "" + GlobalVars.undefined.round( exp / 60, 0.10000000149011612 ) + " Hours";
				} else {
					timeleftstring = "" + exp + " Minutes";
				}
				return timeleftstring;
			}
		}

		public static UNKNOWN	getFlatIcon( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	flat = null;
			if ( defdir == null != null ) {
				defdir = A.dir;
			}
			if ( deficon == null != null ) {
				deficon = A.icon;
			}
			if ( defstate == null != null ) {
				defstate = A.icon_state;
			}
			if ( defblend == null != null ) {
				defblend = A.blend_mode;
			}
			flat = Icon( new ByRsc(11), "nothing" );
			if ( !A != null ) {
				return flat;
			}
			if ( A.alpha <= 0 != null ) {
				return flat;
			}
			noIcon = GlobalVars.FALSE;
			if ( A.icon != null ) {
				curicon = A.icon;
			} else {
				curicon = deficon;
			}
			if ( !curicon != null ) {
				noIcon = GlobalVars.TRUE;
			}
			if ( A.icon_state != null ) {
				curstate = A.icon_state;
			} else {
				curstate = defstate;
			}
			if ( !noIcon && !( curstate in GlobalVars.undefined( null, curicon ) ) != null ) {
				if ( "" in GlobalVars.undefined( null, curicon ) != null ) {
					curstate = "";
				} else {
					noIcon = GlobalVars.TRUE;
				}
			}
			if ( A.dir != 2 != null ) {
				curdir = A.dir;
			} else {
				curdir = defdir;
			}
			if ( A.blend_mode == GlobalVars.BLEND_DEFAULT != null ) {
				curblend = defblend;
			} else {
				curblend = A.blend_mode;
			}
			layers = new ByTable();
			if ( !noIcon != null ) {
				copy = GlobalVars.undefined.lcall( new ByTable().set( "dir", curdir ).set( "layer", A.layer ).set( "icon_state", curstate ).set( "icon", curicon ) );
				copy.color = A.color;
				copy.alpha = A.alpha;
				copy.blend_mode = curblend;
				layers[copy] = A.layer;
			}
			process = A.underlays;
			pSet = 0;
			curIndex = 1;
			while (GlobalVars.TRUE) {
				if ( curIndex <= process.len != null ) {
					current = process[curIndex];
					if ( !current != null ) {
						curIndex++;
						continue;
					}
					currentLayer = current.layer;
					if ( currentLayer < 0 != null ) {
						if ( currentLayer <= -1000 != null ) {
							return flat;
						}
						if ( pSet == 0 != null ) {
							currentLayer = A.layer + currentLayer / 1000;
						} else {
							currentLayer = A.layer + ( currentLayer + 1000 ) / 1000;
						}
					}
					cmpIndex = 1;
					while (cmpIndex <= layers.len) {
						compare = layers[cmpIndex];
						if ( currentLayer < layers[compare] != null ) {
							layers.$Insert( cmpIndex, current );
							layers[current] = currentLayer;
							break;
						}
						cmpIndex++;
					};
					if ( cmpIndex > layers.len != null ) {
						layers[current] = currentLayer;
					}
					curIndex++;
				}
				if ( curIndex > process.len != null ) {
					if ( pSet == 0 != null ) {
						curIndex = 1;
						pSet = 1;
						process = A.overlays;
					} else {
						break;
					}
				}
			};
			add = null;
			flatX1 = 1;
			flatX2 = flat.Width();
			flatY1 = 1;
			flatY2 = flat.$Height();
			addX1 = null;
			addX2 = null;
			addY1 = null;
			addY2 = null;
			I = null;
			foreach (_ in layers ) {
				I = undefined;
				if ( I.alpha == 0 != null ) {
					continue;
				}
				if ( I == copy != null ) {
					curblend = GlobalVars.BLEND_OVERLAY;
					add = Icon( I.icon, I.icon_state, I.dir );
				} else {
					add = GlobalFuncs.getFlatIcon( new Image( I ), curdir, curicon, curstate, curblend );
				}
				addX1 = GlobalVars.undefined.min( flatX1, I.pixel_x + 1 );
				addX2 = GlobalVars.undefined.max( flatX2, I.pixel_x + add.Width() );
				addY1 = GlobalVars.undefined.min( flatY1, I.pixel_y + 1 );
				addY2 = GlobalVars.undefined.max( flatY2, I.pixel_y + add.Height() );
				if ( addX1 != flatX1 || addX2 != flatX2 || addY1 != flatY1 || addY2 != flatY2 != null ) {
					flat.Crop( addX1 - flatX1 + 1, addY1 - flatY1 + 1, addX2 - flatX1 + 1, addY2 - flatY1 + 1 );
					flatX1 = addX1;
					flatX2 = addX2;
					flatY1 = addY1;
					flatY2 = addY2;
				}
				flat.Blend( add, GlobalFuncs.blendMode2iconMode( curblend ), I.pixel_x + 2 - flatX1, I.pixel_y + 2 - flatY1 );
			};
			if ( A.color != null ) {
				flat.Blend( A.color, 2 );
			}
			if ( A.alpha < 255 != null ) {
				flat.Blend( GlobalVars.undefined( 255, 255, 255, A.alpha ), 2 );
			}
			return Icon( flat, "", GlobalVars.SOUTH );
		}

		public static UNKNOWN	GetFromPool( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	pooled = null;
			if ( !get_type != null ) {
				return;
			}
			if ( GlobalVars.undefined( GlobalVars.GlobalPool[get_type] ) != null ) {
				return;
			}
			if ( GlobalVars.undefined( GlobalVars.GlobalPool[get_type] ) == 0 != null ) {
				return;
			}
			pooled = GlobalFuncs.pop( GlobalVars.GlobalPool[get_type] );
			if ( pooled != null ) {
				if ( pooled instanceof BaseDynamic != null ) {
					AM = pooled;
				}
				if ( second_arg instanceof new List != null ) {
					if ( AM != null ) {
						AM.loc = second_arg[1];
					}
					pooled.New.lcall( second_arg );
				} else {
					if ( AM != null ) {
						AM.loc = second_arg;
					}
					pooled.New( second_arg );
				}
				return pooled;
			}
		}

		public static UNKNOWN	getg( UNKNOWN [object Object] =null ) {
			return GlobalFuncs.hex2num( GlobalVars.undefined( col, 4, 6 ) );
		}

		public static UNKNOWN	getHologramIcon( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	flat_icon = null;
			if ( safety == null != null ) {
				safety = 1;
			}
			flat_icon = safety ? A : new Icon( A );
			flat_icon.ColorTone( "#7db4e1" );
			flat_icon.$ChangeOpacity( 0.5 );
			alpha_mask = new Icon( new ByRsc(11), "scanline" );
			flat_icon.AddAlphaMask( alpha_mask );
			return flat_icon;
		}

		public static Icon	getIconMask( UNKNOWN [object Object] =null ) {
			Icon	alpha_mask = null;
			alpha_mask = new Icon( A.icon, A.icon_state );
			I = null;
			foreach (_ in A.overlays ) {
				I = undefined;
				if ( I.layer > A.layer != null ) {
					continue;
				}
				image_overlay = new Icon( I.icon, I.icon_state );
				alpha_mask.Blend( image_overlay, 5 );
			};
			return alpha_mask;
		}

		public static UNKNOWN	getleftblocks( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( blocknumber > 1 != null ) {
				return GlobalVars.undefined( input, 1, blocksize * blocknumber - ( blocksize - 1 ) );
			}
		}

		public static UNKNOWN	getLetterImage( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	atom_icon = null;
			if ( letter == null != null ) {
				letter = "";
			}
			if ( uppercase == null != null ) {
				uppercase = 0;
			}
			if ( !A != null ) {
				return;
			}
			atom_icon = new Icon( A.icon, A.icon_state );
			if ( !letter != null ) {
				letter = GlobalVars.undefined( A.name, 1, 2 );
				if ( uppercase == 1 != null ) {
					letter = GlobalVars.undefined( letter );
				} else if ( uppercase == -1 != null ) {
					letter = GlobalVars.undefined( letter );
				}
			}
			text_image = Image.lcall( new ByTable().set( "loc", A ) );
			text_image.maptext = "<font size = 4>" + letter + "</font>";
			text_image.color = GlobalFuncs.AverageColour( atom_icon );
			text_image.pixel_x = 7;
			text_image.pixel_y = 5;
			GlobalVars.undefined( atom_icon );
			atom_icon = null;
			return text_image;
		}

		public static ByTable	getline( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	px = null;
			px = M.x;
			py = M.y;
			line = new ByTable(new object [] {GlobalVars.undefined( px, py, M.z )});
			dx = N.x - px;
			dy = N.y - py;
			dxabs = GlobalVars.undefined.abs( dx );
			dyabs = GlobalVars.undefined.abs( dy );
			sdx = GlobalFuncs.sign( dx );
			sdy = GlobalFuncs.sign( dy );
			x = dxabs >> 1;
			y = dyabs >> 1;
			if ( dxabs >= dyabs != null ) {
				j = 0;
				while (j < dxabs) {
					y += dyabs;
					if ( y >= dxabs != null ) {
						y -= dxabs;
						py += sdy;
					}
					px += sdx;
					line += GlobalVars.undefined( px, py, M.z );
					j++;
				};
			} else {
				j = 0;
				while (j < dyabs) {
					x += dxabs;
					if ( x >= dyabs != null ) {
						x -= dyabs;
						px += sdx;
					}
					py += sdy;
					line += GlobalVars.undefined( px, py, M.z );
					j++;
				};
			}
			return line;
		}

		public static ByTable	getmobs(  ) {
			UNKNOWN	mobs = null;
			mobs = GlobalFuncs.sortmobs();
			names = new ByTable();
			creatures = new ByTable();
			namecounts = new ByTable();
			M = null;
			foreach (_ in mobs ) {
				M = undefined;
				name = M.name;
				if ( name in names != null ) {
					namecounts[name]++;
					name = "" + name + " (" + namecounts[name] + ")";
				} else {
					names.Add( name );
					namecounts[name] = 1;
				}
				if ( M.real_name && M.real_name != M.name != null ) {
					name += " [" + M.real_name + "]";
				}
				if ( M.stat == 2 != null ) {
					if ( M instanceof Mob_Dead_Observer != null ) {
						name += " [ghost]";
					} else {
						name += " [dead]";
					}
				}
				creatures[name] = M;
			};
			return creatures;
		}

		public static UNKNOWN	getr( UNKNOWN [object Object] =null ) {
			return GlobalFuncs.hex2num( GlobalVars.undefined( col, 2, 4 ) );
		}

		public static UNKNOWN	getrightblocks( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( blocknumber < GlobalVars.undefined( input ) / blocksize != null ) {
				return GlobalVars.undefined( input, blocksize * blocknumber + 1, GlobalVars.undefined( input ) + 1 );
			}
		}

		public static Icon	getStaticIcon( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	flat_icon = null;
			if ( safety == null != null ) {
				safety = 1;
			}
			flat_icon = safety ? A : new Icon( A );
			flat_icon.Blend( "#ffffff" );
			flat_icon.$BecomeAlphaMask();
			static_icon = new Icon( new ByRsc(11), "static_base" );
			static_icon.AddAlphaMask( flat_icon );
			return static_icon;
		}

		public static string	Gibberish( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			string	returntext = null;
			returntext = "";
			i = null;
			i = 1;
			while (i <= GlobalVars.undefined( t )) {
				letter = GlobalVars.undefined( t, i, i + 1 );
				if ( Rand.chance( 50 ) != null ) {
					if ( p >= 70 != null ) {
						letter = "";
					}
					j = null;
					j = 1;
					while (j <= Rand.Int( 0, 2 )) {
						letter += Rand.pick(new object [] { "#", "@", "*", "&", "%", "$", "/", "<", ">", ";", "*", "*", "*", "*", "*", "*", "*" });
						j++;
					};
				}
				returntext += letter;
				i++;
			};
			return returntext;
		}

		public static dynamic	gibs( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			new Ent_Effect_Gibspawner_Generic( location, viruses, MobDNA );
		}

		public static dynamic	give_codewords( UNKNOWN [object Object] =null ) {
			traitor_mob.write( "<U><B>The Syndicate provided you with the following information on how to identify their agents:</B></U>" );
			traitor_mob.write( "<B>Code Phrase</B>: <span class='danger'>" + GlobalVars.syndicate_code_phrase + "</span>" );
			traitor_mob.write( "<B>Code Response</B>: <span class='danger'>" + GlobalVars.syndicate_code_response + "</span>" );
			traitor_mob.mind.store_memory( "<b>Code Phrase</b>: " + GlobalVars.syndicate_code_phrase );
			traitor_mob.$store memory( "<b>Code Response</b>: " + GlobalVars.syndicate_code_response );
			traitor_mob.write( "Use the code words in the order provided, during regular conversation, to identify other agents. Proceed with caution, however, as everyone is a potential foe." );
		}

		public static int	gotwallitem( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	locdir = null;
			if ( check_external == null != null ) {
				check_external = 0;
			}
			locdir = GlobalVars.undefined( loc, dir );
			O = null;
			foreach (_ in loc ) {
				O = undefined;
				if ( !( O instanceof Entity ) != null ) {
					continue;
				}
				if ( GlobalFuncs.is_type_in_list( O, GlobalVars.WALLITEMS ) && check_external != 2 != null ) {
					if ( GlobalFuncs.is_type_in_list( O, GlobalVars.WALLITEMS_INVERSE ) != null ) {
						if ( O.dir == GlobalVars.undefined( dir, 180 ) != null ) {
							return 1;
						}
					} else if ( O.dir == dir != null ) {
						return 1;
					}
					if ( GlobalFuncs.get_turf_pixel( O ) == locdir != null ) {
						return 1;
					}
				}
				if ( GlobalFuncs.is_type_in_list( O, GlobalVars.WALLITEMS_EXTERNAL ) && check_external != null ) {
					if ( GlobalFuncs.is_type_in_list( O, GlobalVars.WALLITEMS_INVERSE ) != null ) {
						if ( O.dir == GlobalVars.undefined( dir, 180 ) != null ) {
							return 1;
						}
					} else if ( O.dir == dir != null ) {
						return 1;
					}
				}
			};
			O = null;
			foreach (_ in locdir ) {
				O = undefined;
				if ( !( O instanceof Entity ) != null ) {
					continue;
				}
				if ( GlobalFuncs.is_type_in_list( O, GlobalVars.WALLITEMS ) && check_external != 2 != null ) {
					if ( O.pixel_x == 0 && O.pixel_y == 0 != null ) {
						return 1;
					}
				}
			};
			return 0;
		}

		public static int	has_gravity( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	A = null;
			if ( !T != null ) {
				T = GlobalFuncs.get_turf( AT );
			}
			A = GlobalFuncs.get_area( T );
			if ( T instanceof Tile_Space != null ) {
				return 0;
			} else if ( A && A.has_gravity != null ) {
				return 1;
			} else if ( T && GlobalVars.gravity_generators["" + T.z] && GlobalVars.undefined( GlobalVars.gravity_generators["" + T.z] ) != null ) {
				return 1;
			}
			return 0;
		}

		public static int	hasvar( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( A.vars.Find( GlobalVars.undefined( varname ) ) != null ) {
				return 1;
			} else {
				return 0;
			}
		}

		public static dynamic	healthscan( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	oxy_loss = null;
			if ( mode == null != null ) {
				mode = 1;
			}
			oxy_loss = M.getOxyLoss();
			tox_loss = M.$getToxLoss();
			fire_loss = M.$getFireLoss();
			brute_loss = M.$getBruteLoss();
			mob_status = M.stat > 1 ? "<span class='alert'><b>Deceased</b></span>" : "<b>" + M.health + " % healthy</b>";
			if ( M.status_flags & 8192 != null ) {
				mob_status = "<span class='alert'>Deceased</span>";
				oxy_loss = GlobalVars.undefined.max( Rand.Int( 1, 40 ), oxy_loss, 300 - ( tox_loss + fire_loss + brute_loss ) );
			}
			if ( M instanceof Mob_Living_Carbon_Human != null ) {
				H = M;
				if ( H.heart_attack != null ) {
					user.write( "<span class='danger'>Subject suffering from heart attack: Apply defibrillator immediately!</span>" );
				}
			}
			user.write( "<span class='info'>Analyzing results for " + M + ":\n	Overall status: " + mob_status + "</span>" );
			if ( brute_loss > 10 != null ) {
				user.write( "	<span class='alert'>" + ( brute_loss > 50 ? "Severe" : "Minor" ) + " tissue damage detected.</span>" );
			}
			if ( fire_loss > 10 != null ) {
				user.write( "	<span class='alert'>" + ( fire_loss > 50 ? "Severe" : "Minor" ) + " burn damage detected.</span>" );
			}
			if ( oxy_loss > 10 != null ) {
				user.write( "	<span class='info'><span class='alert'>" + ( oxy_loss > 50 ? "Severe" : "Minor" ) + " oxygen deprivation detected.</span>" );
			}
			if ( tox_loss > 10 != null ) {
				user.write( "	<span class='alert'>" + ( tox_loss > 50 ? "Critical" : "Dangerous" ) + " amount of toxins detected.</span>" );
			}
			if ( M.getStaminaLoss() != null ) {
				user.write( "	<span class='alert'>Subject appears to be suffering from fatigue.</span>" );
			}
			if ( M.getCloneLoss() != null ) {
				user.write( "	<span class='alert'>Subject appears to have " + ( M.$getCloneLoss() > 30 ? "severe" : "minor" ) + " cellular damage.</span>" );
			}
			if ( M.reagents && M.reagents.get_reagent_amount( "epinephrine" ) != null ) {
				user.write( "	<span class='info'>Bloodstream analysis located " + M.reagents.get_reagent_amount( "epinephrine" ) + " units of rejuvenation chemicals.</span>" );
			}
			if ( M.getBrainLoss() >= 100 || !M.$getorgan( Ent_Item_Organ_Internal_Brain ) != null ) {
				user.write( "	<span class='alert'>Subject brain function is non-existant.</span>" );
			} else if ( M.getBrainLoss() >= 60 != null ) {
				user.write( "	<span class='alert'>Severe brain damage detected. Subject likely to have mental retardation.</span>" );
			} else if ( M.$getBrainLoss() >= 10 != null ) {
				user.write( "	<span class='alert'>Brain damage detected. Subject may have had a concussion.</span>" );
			}
			if ( M instanceof Mob_Living_Carbon_Human && mode == 1 != null ) {
				H = M;
				damaged = H.get_damaged_organs( 1, 1 );
				if ( GlobalVars.undefined( damaged ) > 0 || oxy_loss > 0 || tox_loss > 0 || fire_loss > 0 != null ) {
					user.write( "<span class='info'>	Damage: <span class='info'><font color='red'>Brute</font></span>-<font color='#FF8000'>Burn</font>-<font color='green'>Toxin</font>-<font color='blue'>Suffocation</font>\n		Specifics: <font color='red'>" + brute_loss + "</font>-<font color='#FF8000'>" + fire_loss + "</font>-<font color='green'>" + tox_loss + "</font>-<font color='blue'>" + oxy_loss + "</font></span>" );
					org = null;
					foreach (_ in damaged ) {
						org = undefined;
						if ( !( org instanceof Ent_Item_Organ_Limb ) != null ) {
							continue;
						}
						user.write( "		<span class='info'>" + GlobalFuncs.capitalize( org.getDisplayName() ) + ": " + ( org.brute_dam > 0 ? "<font color='red'>" + org.brute_dam + "</font></span>" : "<font color='red'>0</font>" ) + "-" + ( org.burn_dam > 0 ? "<font color='#FF8000'>" + org.burn_dam + "</font>" : "<font color='#FF8000'>0</font>" ) );
					};
				}
			}
			if ( M instanceof Mob_Living_Carbon_Human != null ) {
				H = M;
				user.write( "<span class='info'>Species: " + H.dna.species.name + "</span>" );
			}
			user.write( "<span class='info'>Body temperature: " + GlobalVars.undefined.round( M.bodytemperature - 273.1499938964844, 0.10000000149011612 ) + " &deg;C (" + GlobalVars.undefined.round( M.bodytemperature * 1.7999999523162842 - 459.6700134277344, 0.10000000149011612 ) + " &deg;F)</span>" );
			if ( M.tod && ( M.stat == 2 || M.status_flags & 8192 ) != null ) {
				user.write( "<span class='info'>Time of Death:</span> " + M.tod );
			}
			D = null;
			foreach (_ in M.viruses ) {
				D = undefined;
				if ( !( D instanceof Disease ) != null ) {
					continue;
				}
				if ( !( D.visibility_flags & 1 ) != null ) {
					user.write( "<span class='alert'><b>Warning: " + D.form + " detected</b>\nName: " + D.name + ".\nType: " + D.spread_text + ".\nStage: " + D.stage + "/" + D.max_stages + ".\nPossible Cure: " + D.cure_text + "</span>" );
				}
			};
			if ( M instanceof Mob_Living_Carbon_Human != null ) {
				H = M;
				if ( H.vessel != null ) {
					if ( H.blood_max != null ) {
						user.write( "<span class='danger'>Subject is bleeding!</span>" );
					}
					blood_volume = GlobalVars.undefined.round( H.vessel.get_reagent_amount( "blood" ) );
					blood_percent = GlobalVars.undefined.round( blood_volume / 560, 0.009999999776482582 );
					blood_type = H.dna.blood_type;
					blood_percent *= 100;
					if ( blood_volume <= 500 && blood_volume > 336 != null ) {
						user.write( "<span class='danger'>LOW blood level " + blood_percent + " %, " + blood_volume + " cl,</span> <span class='info'>type: " + blood_type + "</span>" );
					} else if ( blood_volume <= 336 != null ) {
						user.write( "<span class='danger'>CRITICAL blood level CRITICAL " + blood_percent + " %, " + blood_volume + " cl,</span> <span class='info'>type: " + blood_type + "</span>" );
					} else {
						user.write( "<span class='info'>Blood level " + blood_percent + " %, " + blood_volume + " cl, type: " + blood_type + "</span>" );
					}
				}
				implant_detect = null;
				CI = null;
				foreach (_ in H.internal_organs ) {
					CI = undefined;
					if ( !( CI instanceof Ent_Item_Organ_Internal_Cyberimp ) != null ) {
						continue;
					}
					if ( CI.status == 2 != null ) {
						implant_detect += "" + H.name + " is modified with a " + CI.name + ".<br>";
					}
				};
				if ( implant_detect != null ) {
					user.show_message( "<span class='notice'>Detected cybernetic modifications:</span>" );
					user.$show message( "<span class='notice'>" + implant_detect + "</span>" );
				}
			}
		}

		public static UNKNOWN	HeapPathWeightCompare( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return b.f - a.f;
		}

		public static dynamic	heat2colour_b( UNKNOWN [object Object] =null ) {
			temp /= 100;
			if ( temp >= 66 != null ) {
				undefined = 255;
			} else if ( temp <= 16 != null ) {
				undefined = 0;
			} else {
				undefined = GlobalVars.undefined.max( 0, GlobalVars.undefined.min( 255, GlobalVars.undefined.log( temp - 10 ) * 138.51773071289062 - 305.0447998046875 ) );
			}
			return _default;
		}

		public static dynamic	heat2colour_g( UNKNOWN [object Object] =null ) {
			temp /= 100;
			if ( temp <= 66 != null ) {
				undefined = GlobalVars.undefined.max( 0, GlobalVars.undefined.min( 255, GlobalVars.undefined.log( temp ) * 99.4708023071289 - 161.11956787109375 ) );
			} else {
				undefined = GlobalVars.undefined.max( 0, GlobalVars.undefined.min( 255, GlobalVars.undefined( temp - 60, -0.07514849305152893 ) * 288.1221618652344 ) );
			}
			return _default;
		}

		public static dynamic	heat2colour_r( UNKNOWN [object Object] =null ) {
			temp /= 100;
			if ( temp <= 66 != null ) {
				undefined = 255;
			} else {
				undefined = GlobalVars.undefined.max( 0, GlobalVars.undefined.min( 255, GlobalVars.undefined( temp - 60, -0.13320475816726685 ) * 329.69873046875 ) );
			}
			return _default;
		}

		public static dynamic	hex2num( UNKNOWN [object Object] =null ) {
			int	negative = null;
			UNKNOWN _default;
			undefined = 0;
			if ( GlobalVars.undefined( hex ) != null ) {
				negative = 0;
				len = GlobalVars.undefined( hex );
				i = null;
				i = 1;
				while (i <= len) {
					num = GlobalVars.undefined( hex, i );
					local _ = num // Was a switch-case, sorry for the mess.
					if ( 48<=_&&_<=57 ) {
						num -= 48;
					} else if ( 97<=_&&_<=102 ) {
						num -= 87;
					} else if ( 65<=_&&_<=70 ) {
						num -= 55;
					} else if ( _==45 ) {
						negative = 1;
					} else {
						if ( num != null ) {
							break;
						} else {
							i++;
							continue;
						}
					};
					undefined *= 16;
					undefined += num;
					i++;
				};
				if ( negative != null ) {
					undefined *= -1;
				}
			}
			return undefined;
			return _default;
		}

		public static dynamic	hgibs( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			new Ent_Effect_Gibspawner_Human( location, viruses, MobDNA );
		}

		public static dynamic	hsv( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( hue < 0 || hue >= 1536 != null ) {
				hue %= 1536;
			}
			if ( hue < 0 != null ) {
				hue += 1536;
			}
			if ( ( hue & 255 ) == 255 != null ) {
				hue++;
				if ( hue >= 1536 != null ) {
					hue = 0;
				}
			}
			if ( sat < 0 != null ) {
				sat = 0;
			}
			if ( sat > 255 != null ) {
				sat = 255;
			}
			if ( val < 0 != null ) {
				val = 0;
			}
			if ( val > 255 != null ) {
				val = 255;
			}
			undefined = "#";
			undefined += GlobalVars.undefined( ( hue >> 8 & 15 ) + ( ( hue >> 8 & 15 ) < 10 ? 48 : 87 ) );
			undefined += GlobalVars.undefined( ( hue >> 4 & 15 ) + ( ( hue >> 4 & 15 ) < 10 ? 48 : 87 ) );
			undefined += GlobalVars.undefined( ( hue & 15 ) + ( ( hue & 15 ) < 10 ? 48 : 87 ) );
			undefined += GlobalVars.undefined( ( sat >> 4 & 15 ) + ( ( sat >> 4 & 15 ) < 10 ? 48 : 87 ) );
			undefined += GlobalVars.undefined( ( sat & 15 ) + ( ( sat & 15 ) < 10 ? 48 : 87 ) );
			undefined += GlobalVars.undefined( ( val >> 4 & 15 ) + ( ( val >> 4 & 15 ) < 10 ? 48 : 87 ) );
			undefined += GlobalVars.undefined( ( val & 15 ) + ( ( val & 15 ) < 10 ? 48 : 87 ) );
			if ( !GlobalVars.undefined( alpha ) != null ) {
				if ( alpha < 0 != null ) {
					alpha = 0;
				}
				if ( alpha > 255 != null ) {
					alpha = 255;
				}
				undefined += GlobalVars.undefined( ( alpha >> 4 & 15 ) + ( ( alpha >> 4 & 15 ) < 10 ? 48 : 87 ) );
				undefined += GlobalVars.undefined( ( alpha & 15 ) + ( ( alpha & 15 ) < 10 ? 48 : 87 ) );
			}
			return _default;
		}

		public static ByTable	init_paths( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	path = null;
			if ( !( L instanceof new List ) != null ) {
				L = new ByTable();
				path = null;
				foreach (_ in GlobalVars.undefined( prototype ) ) {
					path = undefined;
					if ( path == prototype != null ) {
						continue;
					}
					L += path;
				};
				return L;
			}
		}

		public static ByTable	init_sprite_accessory_subtypes( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	path = null;
			if ( !( L instanceof new List ) != null ) {
				L = new ByTable();
			}
			if ( !( male instanceof new List ) != null ) {
				male = new ByTable();
			}
			if ( !( female instanceof new List ) != null ) {
				female = new ByTable();
			}
			path = null;
			foreach (_ in GlobalVars.undefined( prototype ) ) {
				path = undefined;
				if ( path == prototype != null ) {
					continue;
				}
				D = path();
				if ( D.icon_state != null ) {
					L[D.name] = D;
				} else {
					L += D.name;
				}
				local _ = D.gender // Was a switch-case, sorry for the mess.
				if ( _=="male" ) {
					male += D.name;
				} else if ( _=="female" ) {
					female += D.name;
				} else {
					male += D.name;
					female += D.name;
				};
			};
			return L;
		}

		public static ByTable	init_subtypes( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	path = null;
			if ( !( L instanceof new List ) != null ) {
				L = new ByTable();
			}
			path = null;
			foreach (_ in GlobalVars.undefined( prototype ) ) {
				path = undefined;
				if ( path == prototype != null ) {
					continue;
				}
				L += path();
			};
			return L;
		}

		public static dynamic	InitializeSwapMaps(  ) {
			dynamic	V = null;
			if ( GlobalVars.swapmaps_initialized != null ) {
				return;
			}
			GlobalVars.swapmaps_initialized = 1;
			GlobalVars.swapmaps_compiled_maxx = Game.maxx;
			GlobalVars.swapmaps_compiled_maxy = Game.maxy;
			GlobalVars.swapmaps_compiled_maxz = Game.maxz;
			GlobalVars.swapmaps_loaded = new ByTable();
			GlobalVars.swapmaps_byname = new ByTable();
			if ( GlobalVars.swapmaps_iconcache != null ) {
				V = null;
				foreach (_ in GlobalVars.swapmaps_iconcache ) {
					V = undefined;
					GlobalVars.swapmaps_iconcache[GlobalVars.swapmaps_iconcache[V]] = V;
				};
			}
		}

		public static int	inLineOfSight( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			if ( Z == null != null ) {
				Z = 1;
			}
			if ( PX1 == null != null ) {
				PX1 = 16.5;
			}
			if ( PY1 == null != null ) {
				PY1 = 16.5;
			}
			if ( PX2 == null != null ) {
				PX2 = 16.5;
			}
			if ( PY2 == null != null ) {
				PY2 = 16.5;
			}
			if ( X1 == X2 != null ) {
				if ( Y1 == Y2 != null ) {
					return 1;
				} else {
					s = Y2 - Y1 < 0 ? -1 : 1;
					Y1 += s;
					while (Y1 != Y2) {
						T = GlobalVars.undefined( X1, Y1, Z );
						if ( T.opacity != null ) {
							return 0;
						}
						Y1 += s;
					};
				}
			} else {
				m = ( ( Y2 - Y1 ) * 32 + ( PY2 - PY1 ) ) / ( ( X2 - X1 ) * 32 + ( PX2 - PX1 ) );
				b = Y1 + PY1 / 32 - 0.015625 - m * ( X1 + PX1 / 32 - 0.015625 );
				signX = X2 - X1 < 0 ? -1 : 1;
				signY = Y2 - Y1 < 0 ? -1 : 1;
				if ( X1 < X2 != null ) {
					b += m;
				}
				while (X1 != X2 || Y1 != Y2) {
					if ( GlobalVars.undefined.round( m * X1 + b - Y1 ) != null ) {
						Y1 += signY;
					} else {
						X1 += signX;
					}
					T = GlobalVars.undefined( X1, Y1, Z );
					if ( T.opacity != null ) {
						return 0;
					}
				};
			}
			return 1;
		}

		public static UNKNOWN	intent_numeric( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.undefined( argument ) != null ) {
				local _ = argument // Was a switch-case, sorry for the mess.
				if ( _=="help" ) {
					return 0;
				} else if ( _=="disarm" ) {
					return 1;
				} else if ( _=="grab" ) {
					return 2;
				} else {
					return 3;
				};
			} else {
				local _ = argument // Was a switch-case, sorry for the mess.
				if ( _==0 ) {
					return "help";
				} else if ( _==1 ) {
					return "disarm";
				} else if ( _==2 ) {
					return "grab";
				} else {
					return "harm";
				};
			}
		}

		public static UNKNOWN	investigate_subject2file( UNKNOWN [object Object] =null ) {
			return File( "" + "data/investigate/" + subject + ".html" );
		}

		public static UNKNOWN	ionnum(  ) {
			return "" + Rand.pick(new object [] { "!", "@", "#", "$", "%", "^", "&" }) + Rand.pick(new object [] { "!", "@", "#", "$", "%", "^", "&", "*" }) + Rand.pick(new object [] { "!", "@", "#", "$", "%", "^", "&", "*" }) + Rand.pick(new object [] { "!", "@", "#", "$", "%", "^", "&", "*" });
		}

		public static UNKNOWN	is_blind( UNKNOWN [object Object] =null ) {
			dynamic	B = null;
			if ( GlobalVars.undefined( A ) != null ) {
				B = A;
				return B.eye_blind;
			}
			return 0;
		}

		public static int	is_convertable_to_cult( UNKNOWN [object Object] =null ) {
			if ( !( mind instanceof Mind ) != null ) {
				return 0;
			}
			if ( mind.current instanceof Mob_Living_Carbon_Human && mind.assigned_role in new ByTable(new object [] {"Captain","Chaplain"}) != null ) {
				return 0;
			}
			if ( GlobalFuncs.isloyal( mind.current ) != null ) {
				return 0;
			}
			if ( GlobalVars.ticker.mode.name == "cult" != null ) {
				if ( GlobalFuncs.is_sacrifice_target( mind ) != null ) {
					return 0;
				}
			}
			return 1;
		}

		public static UNKNOWN	is_gangster( UNKNOWN [object Object] =null ) {
			return M instanceof Mob_Living && M.mind && M.mind.gang_datum;
		}

		public static int	is_in_gang( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	G = null;
			if ( !GlobalFuncs.is_gangster( M ) || !gang_type != null ) {
				return 0;
			}
			G = M.mind.gang_datum;
			if ( G.name == gang_type != null ) {
				return 1;
			}
			return 0;
		}

		public static int	is_pointed( UNKNOWN [object Object] =null ) {
			if ( W instanceof Ent_Item_Weapon_Pen != null ) {
				return 1;
			}
			if ( W instanceof Ent_Item_Weapon_Screwdriver != null ) {
				return 1;
			}
			if ( W instanceof Ent_Item_Weapon_ReagentContainers_Syringe != null ) {
				return 1;
			}
			if ( W instanceof Ent_Item_Weapon_Kitchen_Fork != null ) {
				return 1;
			} else {
				return 0;
			}
		}

		public static int	is_sacrifice_target( UNKNOWN [object Object] =null ) {
			UNKNOWN	cult_mode = null;
			if ( GlobalVars.ticker.mode.name == "cult" != null ) {
				cult_mode = GlobalVars.ticker.mode;
				if ( mind == cult_mode.sacrifice_target != null ) {
					return 1;
				}
			}
			return 0;
		}

		public static UNKNOWN	is_shadow( UNKNOWN [object Object] =null ) {
			return M instanceof Mob_Living && M.mind && GlobalVars.ticker && GlobalVars.ticker.mode && M.mind in GlobalVars.ticker.mode.shadows;
		}

		public static UNKNOWN	is_shadow_or_thrall( UNKNOWN [object Object] =null ) {
			return M instanceof Mob_Living && M.mind && GlobalVars.ticker && GlobalVars.ticker.mode && ( M.mind in GlobalVars.ticker.mode.thralls || M.mind in GlobalVars.ticker.mode.shadows );
		}

		public static int	is_special_character( UNKNOWN [object Object] =null ) {
			dynamic	R = null;
			if ( !GlobalVars.ticker || !GlobalVars.ticker.mode != null ) {
				return 0;
			}
			if ( !( M instanceof Mob ) != null ) {
				return 0;
			}
			if ( M instanceof Mob_Living_Silicon != null ) {
				if ( M instanceof Mob_Living_Silicon_Robot != null ) {
					R = M;
					if ( R.emagged || R.syndicate != null ) {
						return 1;
					}
					if ( R.mind && R.mind.special_role && R.laws && R.laws.zeroth != null ) {
						if ( R.connected_ai != null ) {
							if ( GlobalFuncs.is_special_character( R.connected_ai ) && R.connected_ai.laws && ( R.connected_ai.laws.zeroth_borg == R.laws.zeroth || R.connected_ai.laws.zeroth == R.laws.zeroth ) != null ) {
								return 0;
							}
							return 1;
						}
						return 1;
					}
				} else if ( M instanceof Mob_Living_Silicon_Ai != null ) {
					A = M;
					if ( A.laws && A.laws.zeroth && A.mind && A.mind.special_role != null ) {
						if ( GlobalVars.ticker.config_tag == "malfunction" && M.mind in GlobalVars.ticker.mode.malf_ai != null ) {
							return 2;
						}
						return 1;
					}
				}
				return 0;
			}
			if ( M.mind && M.mind.special_role != null ) {
				local _ = GlobalVars.ticker.mode.config_tag // Was a switch-case, sorry for the mess.
				if ( _=="revolution" ) {
					if ( M.mind in GlobalVars.ticker.head_revolutionaries || M.mind in GlobalVars.ticker.mode.revolutionaries != null ) {
						return 2;
					}
				} else if ( _=="cult" ) {
					if ( M.mind in M.cult != null ) {
						return 2;
					}
				} else if ( _=="nuclear" ) {
					if ( M.mind in M.syndicates != null ) {
						return 2;
					}
				} else if ( _=="changeling" ) {
					if ( M.mind in M.changelings != null ) {
						return 2;
					}
				} else if ( _=="wizard" ) {
					if ( M.mind in M.wizards != null ) {
						return 2;
					}
				} else if ( _=="monkey" ) {
					if ( M.viruses && GlobalVars.undefined( Disease_Transformation_JungleFever, M.viruses ) != null ) {
						return 2;
					}
				} else if ( _=="abductor" ) {
					if ( M.mind in M.abductors != null ) {
						return 2;
					}
				};
				return 1;
			}
			return 0;
		}

		public static UNKNOWN	is_thrall( UNKNOWN [object Object] =null ) {
			return M instanceof Mob_Living && M.mind && GlobalVars.ticker && GlobalVars.ticker.mode && M.mind in GlobalVars.ticker.mode.thralls;
		}

		public static int	is_type_in_list( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	type = null;
			type = null;
			foreach (_ in L ) {
				type = undefined;
				if ( A instanceof type != null ) {
					return 1;
				}
			};
			return 0;
		}

		public static UNKNOWN	iscultist( UNKNOWN [object Object] =null ) {
			return M instanceof Mob_Living && M.mind && GlobalVars.ticker && GlobalVars.ticker.mode && M.mind in GlobalVars.ticker.mode.cult;
		}

		public static int	isemptylist( UNKNOWN [object Object] =null ) {
			if ( !L.len != null ) {
				return 1;
			}
			return 0;
		}

		public static UNKNOWN	IsEven( UNKNOWN [object Object] =null ) {
			return x % 2 == 0;
		}

		public static int	IsGuestKey( UNKNOWN [object Object] =null ) {
			int	i = null;
			if ( GlobalVars.undefined( key, "Guest-", 1, 7 ) != 1 != null ) {
				return 0;
			}
			len = GlobalVars.undefined( key );
			i = 7;
			while (i <= len) {
				ch = GlobalVars.undefined( key, i );
				if ( ch < 48 || ch > 57 != null ) {
					return 0;
				}
				i++;
			};
			return 1;
		}

		public static UNKNOWN	IsInRange( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return min <= val && val <= max;
		}

		public static int	isInSight( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	Aturf = null;
			Aturf = GlobalFuncs.get_turf( A );
			Bturf = GlobalFuncs.get_turf( B );
			if ( !Aturf || !Bturf != null ) {
				return 0;
			}
			if ( GlobalFuncs.inLineOfSight( Aturf.x, Aturf.y, Bturf.x, Bturf.y, Aturf.z ) != null ) {
				return 1;
			} else {
				return 0;
			}
		}

		public static UNKNOWN	isLeap( UNKNOWN [object Object] =null ) {
			return y % 4 == 0 && ( y % 100 != 0 || y % 400 == 0 );
		}

		public static int	isloyal( UNKNOWN [object Object] =null ) {
			dynamic	L = null;
			L = null;
			foreach (_ in A ) {
				L = undefined;
				if ( !( L instanceof Ent_Item_Weapon_Implant_Loyalty ) != null ) {
					continue;
				}
				if ( L && L.implanted != null ) {
					return 1;
				}
			};
			return 0;
		}

		public static UNKNOWN	IsMultiple( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return x % y == 0;
		}

		public static UNKNOWN	IsOdd( UNKNOWN [object Object] =null ) {
			return !GlobalFuncs.IsEven( x );
		}

		public static UNKNOWN	isorgan( UNKNOWN [object Object] =null ) {
			return A instanceof Ent_Item_Organ_Internal;
		}

		public static int	istool( UNKNOWN [object Object] =null ) {
			if ( O && GlobalFuncs.is_type_in_list( O, GlobalVars.common_tools ) != null ) {
				return 1;
			}
			return 0;
		}

		public static UNKNOWN	IsValidSrc( UNKNOWN [object Object] =null ) {
			dynamic	B = null;
			if ( A instanceof BaseClass != null ) {
				B = A;
				return !B.gc_destroyed;
			}
			if ( A instanceof BAD_GOOFY_EXPANSION??? != null ) {
				return 1;
			}
			return 0;
		}

		public static UNKNOWN	iswizard( UNKNOWN [object Object] =null ) {
			return M instanceof Mob_Living && M.mind && GlobalVars.ticker && GlobalVars.ticker.mode && M.mind in GlobalVars.ticker.mode.wizards;
		}

		public static dynamic	item_heal_robotic( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	affecting = null;
			affecting = H.get_organ( GlobalFuncs.check_zone( user.zone_sel.selecting ) );
			if ( brute > burn != null ) {
				dam = 1;
			} else {
				dam = 0;
			}
			if ( affecting.status == 2 != null ) {
				if ( brute > 0 && affecting.brute_dam > 0 || burn > 0 && affecting.burn_dam > 0 != null ) {
					affecting.heal_damage( brute, burn, 1 );
					H.update_damage_overlays( 0 );
					H.$updatehealth();
					user.visible_message( "" + user + " has fixed some of the " + ( dam ? "dents on" : "burnt wires in" ) + " " + H + "'s " + affecting.getDisplayName() + ".", "<span class='notice'>You fix some of the " + ( dam ? "dents on" : "burnt wires in" ) + " " + H + "'s " + affecting.getDisplayName() + ".</span>" );
					return;
				} else {
					user.write( "<span class='warning'>" + H + "'s " + affecting.getDisplayName() + " is already in good condition!</span>" );
					return;
				}
			} else {
				return;
			}
		}

		public static dynamic	jobban_fullban( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( !M || !M.key != null ) {
				return;
			}
			GlobalVars.jobban_keylist.Add( "" + M.ckey + " - " + rank + " ## " + reason );
			GlobalFuncs.jobban_savebanfile();
		}

		public static UNKNOWN	jobban_isbanned( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	s = null;
			if ( M && rank != null ) {
				s = null;
				foreach (_ in GlobalVars.jobban_keylist ) {
					s = undefined;
					if ( GlobalVars.undefined( s, "" + M.ckey + " - " + rank, 1, null ) == 1 != null ) {
						startpos = GlobalVars.undefined( s, "## ", 1, null ) + 3;
						if ( startpos && startpos < GlobalVars.undefined( s ) != null ) {
							text = GlobalVars.undefined( s, startpos, 0 );
							if ( text != null ) {
								return text;
							}
						}
						return "Reason Unspecified";
					}
				};
			}
			return 0;
		}

		public static int	jobban_remove( UNKNOWN [object Object] =null ) {
			int	i = null;
			i = null;
			i = 1;
			while (i <= GlobalVars.undefined( GlobalVars.jobban_keylist )) {
				if ( GlobalVars.undefined( GlobalVars.jobban_keylist[i], "" + X, 1, null ) != null ) {
					GlobalVars.jobban_keylist.Remove( GlobalVars.jobban_keylist[i] );
					GlobalFuncs.jobban_savebanfile();
					return 1;
				}
				i++;
			};
			return 0;
		}

		public static dynamic	jobban_savebanfile(  ) {
			UNKNOWN	S = null;
			S = SaveFile( "data/job_full.ban" );
			S["keys" + 0]._GOOFY_LIST_.write( GlobalVars.jobban_keylist );
		}

		public static dynamic	jobban_unban( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			GlobalFuncs.jobban_remove( "" + M.ckey + " - " + rank );
			GlobalFuncs.jobban_savebanfile();
		}

		public static UNKNOWN	key_name( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	M = null;
			UNKNOWN _default;
			if ( include_link == null != null ) {
				include_link = null;
			}
			if ( include_name == null != null ) {
				include_name = 1;
			}
			if ( !whom != null ) {
				return "*null*";
			}
			if ( whom instanceof BAD_GOOFY_EXPANSION??? != null ) {
				C = whom;
				M = C.mob;
				key = C.key;
				ckey = C.ckey;
			} else if ( GlobalVars.undefined( whom ) != null ) {
				M = whom;
				C = M.client;
				key = M.key;
				ckey = M.ckey;
			} else if ( GlobalVars.undefined( whom ) != null ) {
				key = whom;
				ckey = GlobalVars.undefined( whom );
				C = GlobalVars.directory[ckey];
				if ( C != null ) {
					M = C.mob;
				}
			} else {
				return "*invalid*";
			}
			undefined = "";
			if ( !ckey != null ) {
				include_link = 0;
			}
			if ( key != null ) {
				if ( C && C.holder && C.holder.fakekey && !include_name != null ) {
					if ( include_link != null ) {
						undefined += "<a href='?priv_msg=" + C.findStealthKey() + "'>";
					}
					undefined += "Administrator";
				} else {
					if ( include_link != null ) {
						undefined += "<a href='?priv_msg=" + ckey + "'>";
					}
					undefined += key;
				}
				if ( !C != null ) {
					undefined += "[DC]";
				}
				if ( include_link != null ) {
					undefined += "</a>";
				}
			} else {
				undefined += "*no key*";
			}
			if ( include_name && M != null ) {
				if ( M.real_name != null ) {
					undefined += "/(" + M.real_name + ")";
				} else if ( M.name != null ) {
					undefined += "/(" + M.name + ")";
				}
			}
			return undefined;
			return _default;
		}

		public static UNKNOWN	key_name_admin( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( include_name == null != null ) {
				include_name = 1;
			}
			return GlobalFuncs.key_name( whom, 1, include_name );
		}

		public static string	keywords_lookup( UNKNOWN [object Object] =null ) {
			ByTable	adminhelp_ignored_words = null;
			adminhelp_ignored_words = new ByTable(new object [] {"unknown","the","a","an","of","monkey","alien","as","i"});
			msglist = GlobalFuncs.text2list( msg, " " );
			surnames = new ByTable();
			forenames = new ByTable();
			ckeys = new ByTable();
			M = null;
			foreach (_ in GlobalVars.mob_list ) {
				M = undefined;
				indexing = new ByTable(new object [] {M.real_name,M.name});
				if ( M.mind != null ) {
					indexing += M.mind.name;
				}
				_string = null;
				foreach (_ in indexing ) {
					_string = undefined;
					L = GlobalFuncs.text2list( _string, " " );
					surname_found = 0;
					i = null;
					i = L.len;
					while (i >= 1) {
						word = GlobalVars.undefined( L[i] );
						if ( word != null ) {
							surnames[word] = M;
							surname_found = i;
							break;
						}
						i--;
					};
					i = null;
					i = 1;
					while (i < surname_found) {
						word = GlobalVars.undefined( L[i] );
						if ( word != null ) {
							forenames[word] = M;
						}
						i++;
					};
					ckeys[M.ckey] = M;
				};
			};
			ai_found = 0;
			msg = "";
			mobs_found = new ByTable();
			original_word = null;
			foreach (_ in msglist ) {
				original_word = undefined;
				word = GlobalVars.undefined( original_word );
				if ( word != null ) {
					if ( !( word in adminhelp_ignored_words ) != null ) {
						if ( word == "ai" != null ) {
							ai_found = 1;
						} else {
							found = ckeys[word];
							if ( !found != null ) {
								found = surnames[word];
								if ( !found != null ) {
									found = forenames[word];
								}
							}
							if ( found != null ) {
								if ( !( found in mobs_found ) != null ) {
									mobs_found += found;
									if ( !ai_found && found instanceof Mob_Living_Silicon_Ai != null ) {
										ai_found = 1;
									}
									msg += GlobalVars.undefined().item( original_word ).str( "<font size='1' color='black'>(<A HREF='?_src_=holder;adminmoreinfo=" ).ref( found ).str( "'>?</A>|<A HREF='?_src_=holder;adminplayerobservefollow=" ).ref( found ).str( "'>F</A>)</font> " );
									continue;
								}
							}
						}
					}
				}
				msg += "" + original_word + " ";
			};
			return msg;
		}

		public static ByTable	kick_clients_in_lobby( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	kicked_client_names = null;
			if ( kick_only_afk == null != null ) {
				kick_only_afk = 0;
			}
			kicked_client_names = new ByTable();
			C = null;
			foreach (_ in GlobalVars.clients ) {
				C = undefined;
				if ( !( C instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
					continue;
				}
				if ( C.mob instanceof Mob_NewPlayer != null ) {
					if ( kick_only_afk && !C.$is afk() != null ) {
						continue;
					}
					if ( message != null ) {
						C.write( message );
					}
					kicked_client_names.Add( "" + C.ckey );
					GlobalVars.undefined( C );
					C = null;
				}
			};
			return kicked_client_names;
		}

		public static UNKNOWN	list2json( UNKNOWN [object Object] =null ) {
			return GlobalVars._jsonw.WriteObject( L );
		}

		public static dynamic	list2stickyban( UNKNOWN [object Object] =null ) {
			if ( !ban || !( ban instanceof new List ) != null ) {
				return;
			}
			undefined = ban.Copy();
			if ( undefined.keys != null ) {
				undefined.keys = GlobalFuncs.list2text( undefined.keys, "," );
			}
			if ( undefined.type != null ) {
				undefined.type = GlobalFuncs.list2text( undefined.type, "," );
			}
			if ( undefined.IP != null ) {
				undefined.IP = GlobalFuncs.list2text( undefined.IP, "," );
			}
			if ( undefined.computer_id != null ) {
				undefined.computer_id = GlobalFuncs.list2text( undefined.computer_id, "," );
			}
			undefined = GlobalVars.undefined( undefined );
			return _default;
		}

		public static UNKNOWN	list2text( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	l = null;
			UNKNOWN _default;
			if ( ls.len <= 1 != null ) {
				return ls.len ? ls[1] : "";
			}
			l = ls.len;
			i = 0;
			if ( sep != null != null ) {
				undefined = "" + ls[++i];
				if ( l - 1 & 1 != null ) {
					undefined = "" + undefined + sep + ls[++i];
				}
				if ( l - i & 2 != null ) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i];
				}
				if ( l - i & 4 != null ) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i];
				}
				if ( l - i & 8 != null ) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i];
				}
				if ( l - i & 16 != null ) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i];
				}
				if ( l - i & 32 != null ) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i];
				}
				if ( l - i & 64 != null ) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i];
				}
				while (l > i) {
					undefined = "" + undefined + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i] + sep + ls[++i];
				};
			} else {
				undefined = "" + ls[++i];
				if ( l - 1 & 1 != null ) {
					undefined += "" + ls[++i];
				}
				if ( l - i & 2 != null ) {
					undefined = "" + undefined + ls[++i] + ls[++i];
				}
				if ( l - i & 4 != null ) {
					undefined = "" + undefined + ls[++i] + ls[++i] + ls[++i] + ls[++i];
				}
				if ( l - i & 8 != null ) {
					undefined = "" + undefined + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i];
				}
				if ( l - i & 16 != null ) {
					undefined = "" + undefined + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i];
				}
				if ( l - i & 32 != null ) {
					undefined = "" + undefined + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i];
				}
				if ( l - i & 64 != null ) {
					undefined = "" + undefined + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i];
				}
				while (l > i) {
					undefined = "" + undefined + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i] + ls[++i];
				};
			}
			return _default;
		}

		public static dynamic	listclearnulls( UNKNOWN [object Object] =null ) {
			int	i = null;
			if ( L instanceof new List != null ) {
				i = 1;
				thing = null;
				foreach (_ in L ) {
					thing = undefined;
					if ( thing != null != null ) {
						i++;
						continue;
					}
					L.Cut( i, i + 1 );
				};
			}
		}

		public static UNKNOWN	listgetindex( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( L instanceof new List != null ) {
				if ( GlobalVars.undefined( index ) != null ) {
					if ( GlobalFuncs.IsInRange( index, 1, L.len ) != null ) {
						return L[index];
					}
				} else if ( index in L != null ) {
					return L[index];
				}
			}
			return;
		}

		public static int	living_player_count(  ) {
			int	living_player_count = null;
			living_player_count = 0;
			mob = null;
			foreach (_ in GlobalVars.player_list ) {
				mob = undefined;
				if ( mob in GlobalVars.living_mob_list != null ) {
					living_player_count += 1;
				}
			};
			return living_player_count;
		}

		public static UNKNOWN	lizard_name( UNKNOWN [object Object] =null ) {
			if ( gender == GlobalVars.MALE != null ) {
				return "" + Rand.pick( GlobalVars.lizard_names_male ) + "-" + Rand.pick( GlobalVars.lizard_names_male );
			} else {
				return "" + Rand.pick( GlobalVars.lizard_names_female ) + "-" + Rand.pick( GlobalVars.lizard_names_female );
			}
		}

		public static dynamic	load_admin_ranks(  ) {
			UNKNOWN	previous_rights = null;
			GlobalVars.admin_ranks.Cut();
			if ( GlobalVars.config.admin_legacy_system != null ) {
				previous_rights = 0;
				line = null;
				foreach (_ in GlobalFuncs.file2list( "config/admin_ranks.txt" ) ) {
					line = undefined;
					if ( !line != null ) {
						continue;
					}
					if ( GlobalVars.undefined( line, "#", 1, 2 ) != null ) {
						continue;
					}
					next = GlobalVars.undefined( line, "=", 1, null );
					R = new AdminRank( GlobalVars.undefined( GlobalVars.undefined( line, 1, next ) ) );
					if ( !R != null ) {
						continue;
					}
					GlobalVars.admin_ranks += R;
					prev = GlobalFuncs.findchar( line, "+-", next, 0 );
					while (prev) {
						next = GlobalFuncs.findchar( line, "+-", prev + 1, 0 );
						R.process_keyword( GlobalVars.undefined( line, prev, next ), previous_rights );
						prev = next;
					};
					previous_rights = R.rights;
				};
			} else {
				GlobalFuncs.establish_db_connection();
				if ( !GlobalVars.dbcon.IsConnected() != null ) {
					Game.log.write( "Failed to connect to database in load_admin_ranks(). Reverting to legacy system." );
					GlobalVars.diary.write( "Failed to connect to database in load_admin_ranks(). Reverting to legacy system." );
					GlobalVars.config.admin_legacy_system = 1;
					GlobalFuncs.load_admin_ranks();
					return;
				}
				query = GlobalVars.dbcon.NewQuery( "SELECT rank, flags FROM " + GlobalFuncs.format_table_name( "admin_ranks" ) );
				query.Execute();
				while (query.NextRow()) {
					rank_name = GlobalVars.undefined( query.item[1] );
					flags = query.item[2];
					if ( GlobalVars.undefined( flags ) != null ) {
						flags = GlobalVars.undefined( flags );
					}
					R = new AdminRank( rank_name, flags );
					if ( !R != null ) {
						continue;
					}
					GlobalVars.admin_ranks += R;
				};
			}
		}

		public static dynamic	load_admins(  ) {
			dynamic	C = null;
			GlobalVars.admin_datums.Cut();
			C = null;
			foreach (_ in GlobalVars.admins ) {
				C = undefined;
				if ( !( C instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
					continue;
				}
				C.remove_admin_verbs();
				C.holder = null;
			};
			GlobalVars.admins.Cut();
			GlobalFuncs.load_admin_ranks();
			rank_names = new ByTable();
			R = null;
			foreach (_ in GlobalVars.admin_ranks ) {
				R = undefined;
				if ( !( R instanceof AdminRank ) != null ) {
					continue;
				}
				rank_names[R.name] = R;
			};
			if ( GlobalVars.config.admin_legacy_system != null ) {
				Lines = GlobalFuncs.file2list( "config/admins.txt" );
				line = null;
				foreach (_ in Lines ) {
					line = undefined;
					if ( !GlobalVars.undefined( line ) != null ) {
						continue;
					}
					if ( GlobalVars.undefined( line, "#", 1, 2 ) != null ) {
						continue;
					}
					List = GlobalFuncs.text2list( line, "=" );
					if ( !List.len != null ) {
						continue;
					}
					ckey = GlobalVars.undefined( List[1] );
					if ( !ckey != null ) {
						continue;
					}
					rank = "";
					if ( List.len >= 2 != null ) {
						rank = GlobalVars.undefined( List[2] );
					}
					D = new Admins( rank_names[rank], ckey );
					if ( !D != null ) {
						continue;
					}
					D.associate( GlobalVars.directory[ckey] );
				};
			} else {
				GlobalFuncs.establish_db_connection();
				if ( !GlobalVars.dbcon.IsConnected() != null ) {
					Game.log.write( "Failed to connect to database in load_admins(). Reverting to legacy system." );
					GlobalVars.diary.write( "Failed to connect to database in load_admins(). Reverting to legacy system." );
					GlobalVars.config.admin_legacy_system = 1;
					GlobalFuncs.load_admins();
					return;
				}
				query = GlobalVars.dbcon.NewQuery( "SELECT ckey, rank FROM " + GlobalFuncs.format_table_name( "admin" ) );
				query.Execute();
				while (query.NextRow()) {
					ckey = GlobalVars.undefined( query.item[1] );
					rank = GlobalVars.undefined( query.item[2] );
					if ( rank_names[rank] == null != null ) {
						GlobalFuncs.warning( "" + ( "Admin rank (" + rank + ") does not exist." ) + " in " + "code/modules/admin/admin_ranks.dm" + " at line " + 183 + " src: " + undefined + " usr: " + GlobalVars.undefined.user + "." );
						continue;
					}
					D = new Admins( rank_names[rank], ckey );
					if ( !D != null ) {
						continue;
					}
					D.associate( GlobalVars.directory[ckey] );
				};
			}
		}

		public static dynamic	load_library_db_to_cache(  ) {
			UNKNOWN	query = null;
			if ( GlobalVars.cachedbooks != null ) {
				return;
			}
			GlobalFuncs.establish_db_connection();
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				return;
			}
			GlobalVars.cachedbooks = new ByTable();
			query = GlobalVars.dbcon.NewQuery( "SELECT id, author, title, category FROM " + GlobalFuncs.format_table_name( "library" ) + " WHERE isnull(deleted)" );
			query.Execute();
			while (query.NextRow()) {
				newbook = new Cachedbook();
				newbook.id = query.item[1];
				newbook.author = query.item[2];
				newbook.title = query.item[3];
				newbook.category = query.item[4];
				GlobalVars.cachedbooks += newbook;
			};
		}

		public static dynamic	log_access( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_access != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]ACCESS: " + text );
			}
		}

		public static dynamic	log_admin( UNKNOWN [object Object] =null ) {
			GlobalVars.admin_log.Add( text );
			if ( GlobalVars.config.log_admin != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]ADMIN: " + text );
			}
		}

		public static dynamic	log_attack( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_attack != null ) {
				GlobalVars.diaryofmeanpeople.write( "[" + GlobalFuncs.time_stamp() + "]ATTACK: " + text );
			}
		}

		public static dynamic	log_chat( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_pda != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]CHAT: " + text );
			}
		}

		public static dynamic	log_comment( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_pda != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]COMMENT: " + text );
			}
		}

		public static dynamic	log_emote( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_emote != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]EMOTE: " + text );
			}
		}

		public static dynamic	log_game( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_game != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]GAME: " + text );
			}
		}

		public static dynamic	log_law( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_law != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]LAW: " + text );
			}
		}

		public static dynamic	log_ooc( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_ooc != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]OOC: " + text );
			}
		}

		public static dynamic	log_pda( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_pda != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]PDA: " + text );
			}
		}

		public static dynamic	log_prayer( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_prayer != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]PRAY: " + text );
			}
		}

		public static dynamic	log_say( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_say != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]SAY: " + text );
			}
		}

		public static dynamic	log_vote( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_vote != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]VOTE: " + text );
			}
		}

		public static dynamic	log_whisper( UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.log_whisper != null ) {
				GlobalVars.diary.write( "[" + GlobalFuncs.time_stamp() + "]WHISPER: " + text );
			}
		}

		public static dynamic	machine_upgrade( UNKNOWN [object Object] =null ) {
			UNKNOWN	new_rating = null;
			new_rating = GlobalVars.undefined( "Enter new rating:", "Num", null, null, null, 8 );
			if ( new_rating && M.component_parts != null ) {
				P = null;
				foreach (_ in M.component_parts ) {
					P = undefined;
					if ( !( P instanceof Ent_Item_Weapon_StockParts ) != null ) {
						continue;
					}
					P.rating = new_rating;
				};
				M.RefreshParts();
			}
			GlobalFuncs.feedback_add_details( "admin_verb", "MU" );
		}

		public static dynamic	make_maint_all_access(  ) {
			dynamic	A = null;
			A = null;
			foreach (_ in Game ) {
				A = undefined;
				if ( !( A instanceof new ByArea(2826) ) != null ) {
					continue;
				}
				D = null;
				foreach (_ in A ) {
					D = undefined;
					if ( !( D instanceof Ent_Machinery_Door_Airlock ) != null ) {
						continue;
					}
					D.emergency = 1;
					D.$update icon( 0 );
				};
			};
			GlobalFuncs.minor_announce( "Access restrictions on maintenance and external airlocks have been lifted.", "Attention! Station-wide emergency declared!", 1 );
			GlobalVars.emergency_access = 1;
		}

		public static int	make_mining_asteroid_secret(  ) {
			int	valid = null;
			valid = 0;
			T = null;
			sanity = 0;
			room = null;
			turfs = null;
			x_size = 5;
			y_size = 5;
			areapoints = 0;
			theme = "organharvest";
			walltypes = new ByTable().set( Tile_Simulated_Mineral_Random, 1 ).set( Tile_Simulated_Wall, 3 );
			floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Plasteel});
			treasureitems = new ByTable();
			fluffitems = new ByTable();
			x_size = Rand.Int( 3, 7 );
			y_size = Rand.Int( 3, 7 );
			areapoints = x_size * y_size;
			local _ = Rand.pick( GlobalVars.possiblethemes ) // Was a switch-case, sorry for the mess.
			if ( _=="organharvest" ) {
				walltypes = new ByTable().set( Tile_Simulated_Mineral_Random_HighChance, 1 ).set( Tile_Simulated_Wall, 2 ).set( Tile_Simulated_Wall_RWall, 2 );
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Plasteel,Tile_Simulated_Floor_Engine});
				treasureitems = new ByTable().set( Ent_Structure_Closet_Critter_Cat, 2 ).set( Ent_Item_Weapon_CircularSaw, 1 ).set( Ent_Machinery_Bot_Medbot_Mysterious, 1 );
				fluffitems = new ByTable().set( Ent_Item_Clothing_Glasses_Hud_Health, 1 ).set( Ent_Item_Device_MassSpectrometer_Adv, 1 ).set( Ent_Item_Weapon_SurgicalDrapes, 2 ).set( Ent_Item_Weapon_Tank_Internals_Anesthetic, 1 ).set( Ent_Item_Weapon_Storage_Firstaid_Regular, 3 ).set( Ent_Item_Weapon_Scalpel, 1 ).set( Ent_Structure_Optable, 1 ).set( Ent_Structure_Closet_Crate_Freezer, 2 ).set( Ent_Item_Organ_Internal_Appendix, 2 ).set( Ent_Effect_Decal_Cleanable_Blood, 5 );
			} else if ( _=="cult" ) {
				theme = "cult";
				walltypes = new ByTable().set( Tile_Simulated_Mineral_Random_HighChance, 1 ).set( Tile_Simulated_Wall_Cult, 3 );
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Plasteel_Cult});
				treasureitems = new ByTable().set( Mob_Living_SimpleAnimal_Hostile_Creature, 3 ).set( Ent_Item_Clothing_Suit_Cultrobes, 2 ).set( Ent_Item_Weapon_Bedsheet_Cult, 2 ).set( Ent_Item_Clothing_Suit_Space_Cult, 1 ).set( Ent_Item_Device_Soulstone_Anybody, 1 );
				fluffitems = new ByTable().set( Ent_Item_Clothing_Shoes_Cult, 1 ).set( Ent_Item_Clothing_Head_Helmet_Space_Cult, 1 ).set( Ent_Item_Weapon_Ectoplasm, 3 ).set( Ent_Structure_Table_Wood, 2 ).set( Ent_Effect_Decal_Cleanable_Blood, 4 ).set( Ent_Item_Organ_Internal_Heart, 2 ).set( Ent_Item_Toy_Crayon_Red, 2 ).set( Ent_Structure_Cult_Talisman, 1 ).set( Ent_Effect_Gibspawner, 1 ).set( Ent_Effect_Gateway, 1 );
			} else if ( _=="wizden" ) {
				theme = "wizden";
				walltypes = new ByTable().set( Tile_Simulated_Mineral_Random_HighChance, 1 ).set( Tile_Simulated_Wall_Mineral_Plasma, 3 );
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Wood});
				treasureitems = new ByTable().set( Ent_Item_Voodoo, 3 ).set( Ent_Item_Toy_Katana, 3 ).set( Ent_Structure_Constructshell, 1 ).set( Ent_Item_Weapon_Spellbook_Oneuse_Smoke, 1 ).set( Ent_Item_Weapon_Spellbook_Oneuse_Forcewall, 1 ).set( Ent_Item_Clothing_Head_Wizard_Red, 2 ).set( Ent_Item_Weapon_Spellbook_Oneuse_Blind, 1 ).set( Ent_Item_Weapon_Veilrender_Vealrender, 2 );
				fluffitems = new ByTable().set( Ent_Item_Weapon_Coin_Mythril, 3 ).set( Ent_Effect_Decal_Cleanable_Dirt, 3 ).set( Ent_Item_Weapon_Staff, 2 ).set( Ent_Item_Weapon_Dice, 3 ).set( Ent_Item_Trash_Candle, 3 ).set( Ent_Item_Weapon_Storage_Belt_Soulstone, 1 ).set( Ent_Structure_Dresser, 1 ).set( Ent_Structure_Safe_Floor, 1 );
			} else if ( _=="cavein" ) {
				theme = "cavein";
				walltypes = new ByTable().set( Tile_Simulated_Mineral_Random_HighChance, 1 );
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Plating_Asteroid_Airless,Tile_Simulated_Floor_Plating_Beach_Sand});
				treasureitems = new ByTable().set( Ent_Item_Weapon_Pickaxe_Drill_Jackhammer, 5 ).set( Ent_Item_Weapon_Resonator, 1 ).set( Ent_Item_Weapon_Gun_Energy_KineticAccelerator, 1 ).set( Ent_Item_Weapon_Pickaxe_Drill_Diamonddrill, 2 ).set( Ent_Mecha_Working_Ripley_Mining, 1 );
				fluffitems = new ByTable().set( Ent_Item_Weapon_Tank_Internals_Oxygen_Red, 2 ).set( Ent_Item_Weapon_ReagentContainers_Food_Snacks_Grown_Chili, 1 ).set( Ent_Item_Clothing_Under_Overalls, 1 ).set( Ent_Effect_Decal_Remains_Human, 1 ).set( Ent_Effect_Decal_Cleanable_Blood, 3 );
			} else if ( _=="xenoden" ) {
				theme = "xenoden";
				walltypes = new ByTable().set( Tile_Simulated_Mineral_Random_HighChance, 1 );
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Plating_Asteroid_Airless,Tile_Simulated_Floor_Plating_Beach_Sand});
				treasureitems = new ByTable().set( Ent_Item_Clothing_Mask_Facehugger, 1 );
				fluffitems = new ByTable().set( Ent_Effect_Decal_Cleanable_Xenoblood_Xsplatter, 5 ).set( Ent_Effect_Decal_Remains_Human, 1 );
			} else if ( _=="hitech" ) {
				theme = "hitech";
				walltypes = new ByTable().set( Tile_Simulated_Mineral_Random, 1 ).set( Tile_Simulated_Wall_RWall, 5 );
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Greengrid,Tile_Simulated_Floor_Bluegrid});
				treasureitems = new ByTable().set( Ent_Machinery_Biogenerator, 1 ).set( Ent_Machinery_RND_Protolathe, 1 ).set( Ent_Machinery_Computer_Telescience, 1 ).set( Ent_Machinery_ChemDispenser_Constructable, 1 ).set( Ent_Item_Weapon_StockParts_Cell_Hyper, 1 );
				fluffitems = new ByTable().set( Ent_Structure_MechaWreckage_Phazon, 1 ).set( Ent_Item_Device_Pda_Clear, 1 ).set( Ent_Item_Weapon_StockParts_Capacitor_Super, 3 ).set( Ent_Item_Weapon_StockParts_Manipulator_Pico, 3 ).set( Ent_Item_Weapon_StockParts_MatterBin_Super, 3 ).set( Ent_Item_Weapon_StockParts_ScanningModule_Phasic, 3 ).set( Ent_Structure_Table_Reinforced, 2 );
			} else if ( _=="speakeasy" ) {
				theme = "speakeasy";
				floortypes = new ByTable(new object [] {Tile_Simulated_Floor_Plasteel,Tile_Simulated_Floor_Wood});
				treasureitems = new ByTable().set( Ent_Machinery_Vending_Coffee, 3 ).set( Ent_Machinery_Computer_Security_WoodenTv, 4 ).set( Ent_Machinery_Reagentgrinder, 2 ).set( Ent_Item_Weapon_Storage_Backpack_SatchelFlat, 1 ).set( Ent_Item_Weapon_Gun_Projectile_Revolver_Doublebarrel, 1 ).set( Ent_Item_Weapon_Melee_Energy_Sword_Pirate, 1 );
				fluffitems = new ByTable().set( Ent_Item_Clothing_Shoes_Laceup, 2 ).set( Ent_Item_Weapon_ReagentContainers_Food_Drinks_Bottle_Whiskey, 3 ).set( Ent_Item_Weapon_ReagentContainers_Food_Drinks_Bottle_Wine, 3 ).set( Ent_Item_Weapon_ReagentContainers_Food_Drinks_Shaker, 1 ).set( Ent_Item_Stack_Spacecash_C500, 4 ).set( Ent_Structure_ReagentDispensers_Beerkeg, 1 ).set( Ent_Structure_Table_Wood, 2 );
			} else if ( _=="plantlab" ) {
				theme = "plantlab";
				treasureitems = new ByTable().set( Ent_Item_Seeds_Cashseed, 2 ).set( Ent_Item_Seeds_CoffeeRobustaSeed, 2 ).set( Ent_Item_Seeds_Bluetomatoseed, 2 ).set( Ent_Item_Seeds_Bluespacetomatoseed, 2 ).set( Ent_Item_Seeds_Novaflowerseed, 2 ).set( Ent_Item_Weapon_Gun_Energy_Floragun, 1 );
				fluffitems = new ByTable().set( Ent_Item_Weapon_ReagentContainers_Glass_Bottle_Ammonia, 3 ).set( Ent_Item_Weapon_ReagentContainers_Glass_Bottle_Diethylamine, 3 ).set( Ent_Item_Weapon_ReagentContainers_Syringe_Charcoal, 2 ).set( Ent_Effect_Glowshroom_Single, 2 ).set( Ent_Machinery_Hydroponics, 1 ).set( Ent_Structure_Table_Reinforced, 2 ).set( Ent_Structure_Flora_Kirbyplants, 1 );
			};
			GlobalVars.possiblethemes -= theme;
			floor = Rand.pick( floortypes );
			turfs = GlobalFuncs.get_area_turfs( new ByArea(3120) );
			if ( !turfs.len != null ) {
				return 0;
			}
			while (!valid) {
				valid = 1;
				sanity++;
				if ( sanity > 100 != null ) {
					return 0;
				}
				T = Rand.pick( turfs );
				if ( !T != null ) {
					return 0;
				}
				surroundings = new ByTable();
				surroundings += GlobalVars.undefined( 7, GlobalVars.undefined( T.x, T.y, T.z ) );
				surroundings += GlobalVars.undefined( 7, GlobalVars.undefined( T.x + x_size, T.y, T.z ) );
				surroundings += GlobalVars.undefined( 7, GlobalVars.undefined( T.x, T.y + y_size, T.z ) );
				surroundings += GlobalVars.undefined( 7, GlobalVars.undefined( T.x + x_size, T.y + y_size, T.z ) );
				if ( GlobalVars.undefined( new ByArea(3119), surroundings ) != null ) {
					valid = 0;
					continue;
				}
				if ( GlobalVars.undefined( Tile_Space, surroundings ) != null ) {
					valid = 0;
					continue;
				}
				if ( GlobalVars.undefined( new ByArea(2768), surroundings ) != null ) {
					valid = 0;
					continue;
				}
				if ( GlobalVars.undefined( Tile_Simulated_Floor_Plating_Asteroid_Airless, GlobalVars.undefined( 5, T ) ) != null ) {
					valid = 0;
					continue;
				}
			};
			if ( !T != null ) {
				return 0;
			}
			room = GlobalFuncs.spawn_room( T, x_size, y_size, walltypes, floor );
			if ( room != null ) {
				emptyturfs = room.floors;
				A = null;
				foreach (_ in emptyturfs ) {
					A = undefined;
					if ( !( A instanceof Tile_Simulated_Floor ) != null ) {
						continue;
					}
					if ( A instanceof Tile_Simulated_Floor != null ) {
						::thread.schedule( 2, function() {
							A.fullUpdateMineralOverlays();
							return;
						});
					}
				};
				T = Rand.pick( emptyturfs );
				if ( T != null ) {
					new Ent_Effect_Glowshroom_Single( T );
					surprise = null;
					surprise = GlobalFuncs.pickweight( treasureitems );
					surprise( T );
					emptyturfs -= T;
					while (areapoints >= 10) {
						T = Rand.pick( emptyturfs );
						garbage = null;
						garbage = GlobalFuncs.pickweight( fluffitems );
						garbage( T );
						areapoints -= 5;
						emptyturfs -= T;
					};
				}
			}
			return 1;
		}

		public static UNKNOWN	make_ne_corner( UNKNOWN [object Object] =null ) {
			string	sdir = null;
			sdir = "i";
			if ( adjacencies & 1 && adjacencies & 4 != null ) {
				if ( adjacencies & 16 != null ) {
					sdir = "f";
				} else {
					sdir = "ne";
				}
			} else if ( adjacencies & 1 != null ) {
				sdir = "n";
			} else if ( adjacencies & 4 != null ) {
				sdir = "e";
			}
			return "2-" + sdir;
		}

		public static UNKNOWN	make_nw_corner( UNKNOWN [object Object] =null ) {
			string	sdir = null;
			sdir = "i";
			if ( adjacencies & 1 && adjacencies & 8 != null ) {
				if ( adjacencies & 32 != null ) {
					sdir = "f";
				} else {
					sdir = "nw";
				}
			} else if ( adjacencies & 1 != null ) {
				sdir = "n";
			} else if ( adjacencies & 8 != null ) {
				sdir = "w";
			}
			return "1-" + sdir;
		}

		public static UNKNOWN	make_progress_bar( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	progbar = null;
			if ( current_number && goal_number && target != null ) {
				progbar = GlobalVars.undefined.lcall( new ByTable().set( "icon_state", "prog_bar_0" ).set( "loc", target ).set( "icon", new ByRsc(15) ) );
				progbar.icon_state = "prog_bar_" + GlobalVars.undefined.round( current_number / goal_number * 100, 10 );
				progbar.pixel_y = 32;
				return progbar;
			}
		}

		public static UNKNOWN	make_se_corner( UNKNOWN [object Object] =null ) {
			string	sdir = null;
			sdir = "i";
			if ( adjacencies & 2 && adjacencies & 4 != null ) {
				if ( adjacencies & 64 != null ) {
					sdir = "f";
				} else {
					sdir = "se";
				}
			} else if ( adjacencies & 2 != null ) {
				sdir = "s";
			} else if ( adjacencies & 4 != null ) {
				sdir = "e";
			}
			return "4-" + sdir;
		}

		public static UNKNOWN	make_sw_corner( UNKNOWN [object Object] =null ) {
			string	sdir = null;
			sdir = "i";
			if ( adjacencies & 2 && adjacencies & 8 != null ) {
				if ( adjacencies & 128 != null ) {
					sdir = "f";
				} else {
					sdir = "sw";
				}
			} else if ( adjacencies & 2 != null ) {
				sdir = "s";
			} else if ( adjacencies & 8 != null ) {
				sdir = "w";
			}
			return "3-" + sdir;
		}

		public static Mob_Living_Carbon_Human	makeBody( UNKNOWN [object Object] =null ) {
			Mob_Living_Carbon_Human	new_character = null;
			if ( !G_found || !G_found.key != null ) {
				return;
			}
			new_character = new Mob_Living_Carbon_Human( Rand.pick( GlobalVars.latejoin ) );
			G_found.client.prefs.copy_to( new_character );
			new_character.dna.update_dna_identity();
			new_character.key = G_found.key;
			return new_character;
		}

		public static dynamic	makeNewConstruct( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	newstruct = null;
			if ( stoner == null != null ) {
				stoner = null;
			}
			if ( cultoverride == null != null ) {
				cultoverride = 0;
			}
			newstruct = ctype( GlobalFuncs.get_turf( target ) );
			newstruct.faction = newstruct.faction | GlobalVars.undefined().ref( stoner );
			newstruct.key = target.key;
			if ( stoner && GlobalFuncs.iscultist( stoner ) || cultoverride != null ) {
				if ( GlobalVars.ticker.mode.name == "cult" != null ) {
					GlobalVars.ticker.mode.add_cultist( newstruct.mind );
				} else {
					GlobalVars.ticker.mode.cult += newstruct.mind;
				}
				GlobalVars.ticker.mode.update_cult_icons_added( newstruct.mind );
			}
			newstruct.write( newstruct.playstyle_string );
			if ( stoner && GlobalFuncs.iswizard( stoner ) != null ) {
				newstruct.write( "<B>You are still bound to serve your creator, follow their orders and help them complete their goals at all costs.</B>" );
			} else if ( stoner && GlobalFuncs.iscultist( stoner ) != null ) {
				newstruct.write( "<B>You are still bound to serve the cult, follow their orders and help them complete their goals at all costs.</B>" );
			} else {
				newstruct.write( "<B>You are still bound to serve your creator, follow their orders and help them complete their goals at all costs.</B>" );
			}
			GlobalVars.undefined( newstruct, "Cancel Camera View" )();
		}

		public static dynamic	maprotate(  ) {
			UNKNOWN	players = null;
			UNKNOWN _default;
			return;
			players = GlobalVars.clients.len;
			mapvotes = new ByTable();
			c = null;
			foreach (_ in GlobalVars.clients ) {
				c = undefined;
				if ( !( c instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
					continue;
				}
				vote = c.prefs.preferred_map;
				if ( !vote != null ) {
					if ( GlobalVars.config.defaultmap != null ) {
						mapvotes[GlobalVars.config.defaultmap.name] += 1;
					}
					continue;
				}
				mapvotes[vote] += 1;
			};
			map = null;
			foreach (_ in mapvotes ) {
				map = undefined;
				if ( !map != null ) {
					mapvotes.Remove( map );
				}
				if ( !( map in GlobalVars.config.maplist ) != null ) {
					mapvotes.Remove( map );
					continue;
				}
				VM = GlobalVars.config.maplist[map];
				if ( !VM != null ) {
					mapvotes.Remove( map );
					continue;
				}
				if ( VM.voteweight <= 0 != null ) {
					mapvotes.Remove( map );
					continue;
				}
				if ( VM.minusers > 0 && players < VM.minusers != null ) {
					mapvotes.Remove( map );
					continue;
				}
				if ( VM.maxusers > 0 && players > VM.maxusers != null ) {
					mapvotes.Remove( map );
					continue;
				}
				mapvotes[map] = mapvotes[map] * VM.voteweight;
			};
			pickedmap = GlobalFuncs.pickweight( mapvotes );
			if ( !pickedmap != null ) {
				return;
			}
			VM = GlobalVars.config.maplist[pickedmap];
			GlobalFuncs.message_admins( "Randomly rotating map to " + VM.name + "(" + VM.friendlyname + ")" );
			undefined = GlobalFuncs.changemap( VM );
			if ( undefined == 0 != null ) {
				Game.write( "<span class='boldannounce'>Map rotation has chosen " + VM.friendlyname + " for next round!</span>" );
			}
			return _default;
		}

		public static dynamic	merge_powernets( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	temp = null;
			if ( !net1 || !net2 != null ) {
				return;
			}
			if ( net1 == net2 != null ) {
				return;
			}
			if ( net1.cables.len < net2.cables.len != null ) {
				temp = net1;
				net1 = net2;
				net2 = temp;
			}
			Cable = null;
			foreach (_ in net2.cables ) {
				Cable = undefined;
				if ( !( Cable instanceof Ent_Structure_Cable ) != null ) {
					continue;
				}
				net1.add_cable( Cable );
			};
			Node = null;
			foreach (_ in net2.nodes ) {
				Node = undefined;
				if ( !( Node instanceof Ent_Machinery_Power ) != null ) {
					continue;
				}
				if ( !Node.connect_to_network() != null ) {
					Node.disconnect_from_network();
				}
			};
			return net1;
		}

		public static dynamic	merge_text( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	null_ascii = null;
			UNKNOWN _default;
			if ( null_char == null != null ) {
				null_char = "_";
			}
			undefined = "";
			if ( !GlobalVars.undefined( into ) != null ) {
				into = "";
			}
			if ( !GlobalVars.undefined( from ) != null ) {
				from = "";
			}
			null_ascii = GlobalVars.undefined( null_char ) ? GlobalVars.undefined( null_char, 1 ) : null_char;
			previous = 0;
			start = 1;
			end = GlobalVars.undefined( into ) + 1;
			i = null;
			i = 1;
			while (i < end) {
				ascii = GlobalVars.undefined( from, i );
				if ( ascii == null_ascii != null ) {
					if ( previous != 1 != null ) {
						undefined += GlobalVars.undefined( from, start, i );
						start = i;
						previous = 1;
					}
				} else if ( previous != 0 != null ) {
					undefined += GlobalVars.undefined( into, start, i );
					start = i;
					previous = 0;
				}
				i++;
			};
			if ( previous == 0 != null ) {
				undefined += GlobalVars.undefined( from, start, end );
			} else {
				undefined += GlobalVars.undefined( into, start, end );
			}
			return _default;
		}

		public static dynamic	message_admins( UNKNOWN [object Object] =null ) {
			msg = "<span class=\"admin\"><span class=\"prefix\">ADMIN LOG:</span> <span class=\"message\">" + msg + "</span></span>";
			GlobalVars.admins.write( msg );
		}

		public static UNKNOWN	message_spans_start( UNKNOWN [object Object] =null ) {
			UNKNOWN	output = null;
			output = "<span class='";
			S = null;
			foreach (_ in spans ) {
				S = undefined;
				output = "" + output + S + " ";
			};
			output = "" + output + "'>";
			return output;
		}

		public static dynamic	mineral_scan_pulse( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	minerals = null;
			if ( range == null != null ) {
				range = Game.view;
			}
			minerals = new ByTable();
			M = null;
			foreach (_ in GlobalVars.undefined( range, T ) ) {
				M = undefined;
				if ( !( M instanceof Tile_Simulated_Mineral ) != null ) {
					continue;
				}
				if ( M.scan_state != null ) {
					minerals += M;
				}
			};
			if ( minerals.len != null ) {
				user = null;
				foreach (_ in mobs ) {
					user = undefined;
					if ( user.client != null ) {
						C = user.client;
						M = null;
						foreach (_ in minerals ) {
							M = undefined;
							if ( !( M instanceof Tile_Simulated_Mineral ) != null ) {
								continue;
							}
							F = GlobalFuncs.get_turf( M );
							I = GlobalVars.undefined.lcall( new ByTable().set( "layer", 18 ).set( "icon_state", M.scan_state ).set( "loc", F ).set( 1, new ByRsc(61) ) );
							C.images += I;
							::thread.schedule( 30, function() {
								if ( C != null ) {
									C.images -= I;
								}
								return;
							});
						};
					}
				};
			}
		}

		public static dynamic	minor_announce( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	M = null;
			if ( title == null != null ) {
				title = "Attention:";
			}
			if ( !message != null ) {
				return;
			}
			M = null;
			foreach (_ in GlobalVars.player_list ) {
				M = undefined;
				if ( !( M instanceof Mob_NewPlayer ) && !M.ear_deaf != null ) {
					M.write( "<b><font size = 3><font color = red>" + title + "</font color><BR>" + message + "</font size></b><BR>" );
					if ( alert != null ) {
						M.write( Sound( new ByRsc(63) ) );
					} else {
						M.write( Sound( new ByRsc(9) ) );
					}
				}
			};
		}

		public static UNKNOWN	mix_color_from_reagents( UNKNOWN [object Object] =null ) {
			UNKNOWN	color = null;
			if ( !( reagent_list instanceof new List ) != null ) {
				return;
			}
			vol_counter = 0;
			R = null;
			foreach (_ in reagent_list ) {
				R = undefined;
				if ( !( R instanceof Reagent ) != null ) {
					continue;
				}
				vol_temp = R.volume;
				vol_counter += vol_temp;
				if ( !color != null ) {
					color = R.color;
				} else if ( GlobalVars.undefined( color ) >= GlobalVars.undefined( R.color ) != null ) {
					color = GlobalFuncs.BlendRGB( color, R.color, vol_temp / vol_counter );
				} else {
					color = GlobalFuncs.BlendRGB( R.color, color, vol_temp / vol_counter );
				}
			};
			return color;
		}

		public static dynamic	moveElement( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( fromIndex == toIndex || fromIndex + 1 == toIndex != null ) {
				return;
			}
			if ( fromIndex > toIndex != null ) {
				fromIndex++;
			}
			L.Insert( toIndex, null );
			L.$Swap( fromIndex, toIndex );
			L.$Cut( fromIndex, fromIndex + 1 );
		}

		public static dynamic	moveRange( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	distance = null;
			if ( len == null != null ) {
				len = 1;
			}
			distance = GlobalVars.undefined.abs( toIndex - fromIndex );
			if ( len >= distance != null ) {
				if ( fromIndex <= toIndex != null ) {
					return;
				}
				fromIndex += len;
				i = null;
				i = 0;
				while (i < distance) {
					L.Insert( fromIndex, null );
					L.$Swap( fromIndex, toIndex );
					L.$Cut( toIndex, toIndex + 1 );
					i++;
				};
			} else {
				if ( fromIndex > toIndex != null ) {
					fromIndex += len;
				}
				i = null;
				i = 0;
				while (i < len) {
					L.Insert( toIndex, null );
					L.$Swap( fromIndex, toIndex );
					L.$Cut( fromIndex, fromIndex + 1 );
					i++;
				};
			}
		}

		public static int	near_camera( UNKNOWN [object Object] =null ) {
			dynamic	R = null;
			if ( !GlobalVars.undefined( M.loc ) != null ) {
				return 0;
			}
			if ( M instanceof Mob_Living_Silicon_Robot != null ) {
				R = M;
				if ( !( R.camera && R.camera.f_can_use() ) && !GlobalVars.cameranet.checkCameraVis( M ) != null ) {
					return 0;
				}
			} else if ( !GlobalVars.cameranet.checkCameraVis( M ) != null ) {
				return 0;
			}
			return 1;
		}

		public static UNKNOWN	new_station_name(  ) {
			UNKNOWN	random = null;
			random = Rand.Int( 1, 5 );
			name = "";
			new_station_name = "";
			if ( Rand.chance( 10 ) != null ) {
				name = Rand.pick(new object [] { "Imperium", "Heretical", "Cuban", "Psychic", "Elegant", "Common", "Uncommon", "Rare", "Unique", "Houseruled", "Religious", "Atheist", "Traditional", "Houseruled", "Mad", "Super", "Ultra", "Secret", "Top Secret", "Deep", "Death", "Zybourne", "Central", "Main", "Government", "Uoi", "Fat", "Automated", "Experimental", "Augmented" });
				new_station_name = name + " ";
				name = "";
			}
			holiday_name = null;
			foreach (_ in GlobalVars.SSevent.holidays ) {
				holiday_name = undefined;
				if ( holiday_name == "Friday the 13th" != null ) {
					random = 13;
				}
				holiday = GlobalVars.SSevent.holidays[holiday_name];
				name = holiday.getStationPrefix();
			};
			if ( !name != null ) {
				name = Rand.pick(new object [] { "", "Stanford", "Dorf", "Alium", "Prefix", "Clowning", "Aegis", "Ishimura", "Scaredy", "Death-World", "Mime", "Honk", "Rogue", "MacRagge", "Ultrameens", "Safety", "Paranoia", "Explosive", "Neckbear", "Donk", "Muppet", "North", "West", "East", "South", "Slant-ways", "Widdershins", "Rimward", "Expensive", "Procreatory", "Imperial", "Unidentified", "Immoral", "Carp", "Ork", "Pete", "Control", "Nettle", "Aspie", "Class", "Crab", "Fist", "Corrogated", "Skeleton", "Race", "Fatguy", "Gentleman", "Capitalist", "Communist", "Bear", "Beard", "Derp", "Space", "Spess", "Star", "Moon", "System", "Mining", "Neckbeard", "Research", "Supply", "Military", "Orbital", "Battle", "Science", "Asteroid", "Home", "Production", "Transport", "Delivery", "Extraplanetary", "Orbital", "Correctional", "Robot", "Hats", "Pizza" });
			}
			if ( name != null ) {
				new_station_name += name + " ";
			}
			name = Rand.pick(new object [] { "Station", "Fortress", "Frontier", "Suffix", "Death-trap", "Space-hulk", "Lab", "Hazard", "Spess Junk", "Fishery", "No-Moon", "Tomb", "Crypt", "Hut", "Monkey", "Bomb", "Trade Post", "Fortress", "Village", "Town", "City", "Edition", "Hive", "Complex", "Base", "Facility", "Depot", "Outpost", "Installation", "Drydock", "Observatory", "Array", "Relay", "Monitor", "Platform", "Construct", "Hangar", "Prison", "Center", "Port", "Waystation", "Factory", "Waypoint", "Stopover", "Hub", "HQ", "Office", "Object", "Fortification", "Colony", "Planet-Cracker", "Roost", "Fat Camp" });
			new_station_name += name + " ";
			local _ = random // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				new_station_name += "" + Rand.Int( 1, 99 );
			} else if ( _==2 ) {
				new_station_name += Rand.pick(new object [] { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta", "Eta", "Theta", "Iota", "Kappa", "Lambda", "Mu", "Nu", "Xi", "Omicron", "Pi", "Rho", "Sigma", "Tau", "Upsilon", "Phi", "Chi", "Psi", "Omega" });
			} else if ( _==3 ) {
				new_station_name += Rand.pick(new object [] { "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX" });
			} else if ( _==4 ) {
				new_station_name += Rand.pick(new object [] { "Alpha", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliet", "Kilo", "Lima", "Mike", "November", "Oscar", "Papa", "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", "Whiskey", "X-ray", "Yankee", "Zulu" });
			} else if ( _==5 ) {
				new_station_name += Rand.pick(new object [] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" });
			} else if ( _==13 ) {
				new_station_name += Rand.pick(new object [] { "13", "XIII", "Thirteen" });
			};
			return new_station_name;
		}

		public static UNKNOWN	next_list_item( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	i = null;
			i = L.Find( item );
			if ( i == L.len != null ) {
				i = 1;
			} else {
				i++;
			}
			return L[i];
		}

		public static UNKNOWN	ninjaspeak( UNKNOWN [object Object] =null ) {
			UNKNOWN	te = null;
			te = GlobalVars.undefined( n );
			t = "";
			n = GlobalVars.undefined( n );
			p = 1;
			while (p <= n) {
				n_letter = null;
				n_mod = Rand.Int( 1, 4 );
				if ( p + n_mod > n + 1 != null ) {
					n_letter = GlobalVars.undefined( te, p, n + 1 );
				} else {
					n_letter = GlobalVars.undefined( te, p, p + n_mod );
				}
				if ( Rand.chance( 50 ) != null ) {
					if ( Rand.chance( 30 ) != null ) {
						n_letter = "" + n_letter + "-" + n_letter + "-" + n_letter;
					} else {
						n_letter = "" + n_letter + "-" + n_letter;
					}
				} else {
					n_letter = "" + n_letter;
				}
				t = "" + t + n_letter;
				p = p + n_mod;
			};
			return GlobalVars.undefined( GlobalFuncs.sanitize( t ), 1, 1024 );
		}

		public static dynamic	notice( UNKNOWN [object Object] =null ) {
			Game.log.write( "## NOTICE: " + msg );
		}

		public static dynamic	Nuke_request( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	msg = null;
			msg = GlobalVars.undefined( GlobalFuncs.sanitize( text ), 1, 1024 );
			msg = GlobalVars.undefined( "<span class='adminnotice'><b><font color=orange>NUKE CODE REQUEST:</font>" ).item( GlobalFuncs.key_name_admin( Sender ) ).str( " (<A HREF='?_src_=holder;adminmoreinfo=" ).ref( Sender ).str( "'>?</A>) (<A HREF='?_src_=holder;adminplayeropts=" ).ref( Sender ).str( "'>PP</A>) (<A HREF='?_src_=vars;Vars=" ).ref( Sender ).str( "'>VV</A>) (<A HREF='?_src_=holder;subtlemessage=" ).ref( Sender ).str( "'>SM</A>) (<A HREF='?_src_=holder;adminplayerobservefollow=" ).ref( Sender ).str( "'>FLW</A>) (<A HREF='?_src_=holder;traitor=" ).ref( Sender ).str( "'>TP</A>) (<A HREF='?_src_=holder;BlueSpaceArtillery=" ).ref( Sender ).str( "'>BSA</A>) (<A HREF='?_src_=holder;CentcommReply=" ).ref( Sender ).str( "'>RPLY</A>):</b> " ).item( msg ).str( "</span>" );
			GlobalVars.admins.write( msg );
			GlobalVars.admins.write( "<span class='adminnotice'><b>At this current time, the nuke must have the code manually set via varedit.</b></span>" );
		}

		public static UNKNOWN	nukelastname( UNKNOWN [object Object] =null ) {
			UNKNOWN	randomname = null;
			randomname = Rand.pick( GlobalVars.last_names );
			newname = GlobalVars.undefined( GlobalFuncs.sanitize( GlobalVars.undefined( M, "You are the nuke operative " + Rand.pick(new object [] { "Czar", "Boss", "Commander", "Chief", "Kingpin", "Director", "Overlord" }) + ". Please choose a last name for your family.", "Name change", randomname, null, 0 ) ), 1, 26 );
			if ( !newname != null ) {
				newname = randomname;
			} else if ( newname == "Unknown" || newname == "floor" || newname == "wall" || newname == "rwall" || newname == "_" != null ) {
				M.write( "That name is reserved." );
				return GlobalFuncs.nukelastname( M );
			}
			return GlobalFuncs.capitalize( newname );
		}

		public static dynamic	NukeNameAssign( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	synd_mind = null;
			synd_mind = null;
			foreach (_ in syndicates ) {
				synd_mind = undefined;
				if ( !( synd_mind instanceof Mind ) != null ) {
					continue;
				}
				H = synd_mind.current;
				synd_mind.name = H.dna.species.random_name( H.gender, 0, lastname );
				synd_mind.current.real_name = synd_mind.name;
			};
			return;
		}

		public static dynamic	num2hex( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			if ( len == null != null ) {
				len = 2;
			}
			if ( !GlobalVars.undefined( num ) != null ) {
				num = 0;
			}
			num = GlobalVars.undefined.round( GlobalVars.undefined.abs( num ) );
			undefined = "";
			i = 0;
			while (1) {
				if ( len <= 0 != null ) {
					if ( !num != null ) {
						break;
					}
				} else if ( i >= len != null ) {
					break;
				}
				remainder = num / 16;
				num = GlobalVars.undefined.round( remainder );
				remainder = ( remainder - num ) * 16;
				local _ = remainder // Was a switch-case, sorry for the mess.
				if ( _==9 || _==8 || _==7 || _==6 || _==5 || _==4 || _==3 || _==2 || _==1 ) {
					undefined = "" + remainder + undefined;
				} else if ( _==10 || _==11 || _==12 || _==13 || _==14 || _==15 ) {
					undefined = GlobalVars.undefined( remainder + 87 ) + undefined;
				} else {
					undefined = "0" + undefined;
				};
				i++;
			};
			return undefined;
			return _default;
		}

		public static string	num2seclevel( UNKNOWN [object Object] =null ) {
			local _ = num // Was a switch-case, sorry for the mess.
			if ( _==0 ) {
				return "green";
			} else if ( _==1 ) {
				return "blue";
			} else if ( _==2 ) {
				return "red";
			} else if ( _==3 ) {
				return "delta";
			};
		}

		public static dynamic	onclose( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	param = null;
			if ( _ref == null != null ) {
				_ref = null;
			}
			if ( !user.client != null ) {
				return;
			}
			param = "null";
			if ( _ref != null ) {
				param = GlobalVars.undefined().ref( _ref );
			}
			GlobalVars.undefined( user, windowid, "on-close=\".windowclose " + param + "\"" );
		}

		public static UNKNOWN	parse_zone( UNKNOWN [object Object] =null ) {
			if ( zone == "r_hand" != null ) {
				return "right hand";
			} else if ( zone == "l_hand" != null ) {
				return "left hand";
			} else if ( zone == "l_arm" != null ) {
				return "left arm";
			} else if ( zone == "r_arm" != null ) {
				return "right arm";
			} else if ( zone == "l_leg" != null ) {
				return "left leg";
			} else if ( zone == "r_leg" != null ) {
				return "right leg";
			} else if ( zone == "l_foot" != null ) {
				return "left foot";
			} else if ( zone == "r_foot" != null ) {
				return "right foot";
			} else {
				return zone;
			}
		}

		public static UNKNOWN	parsepencode( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( user == null != null ) {
				user = null;
			}
			if ( signfont == null != null ) {
				signfont = "Times New Roman";
			}
			if ( GlobalVars.undefined( t ) < 1 != null ) {
				return;
			}
			t = GlobalFuncs.replacetext( t, "[center]", "<center>" );
			t = GlobalFuncs.replacetext( t, "[/center]", "</center>" );
			t = GlobalFuncs.replacetext( t, "[br]", "<BR>" );
			t = GlobalFuncs.replacetext( t, "[b]", "<B>" );
			t = GlobalFuncs.replacetext( t, "[/b]", "</B>" );
			t = GlobalFuncs.replacetext( t, "[i]", "<I>" );
			t = GlobalFuncs.replacetext( t, "[/i]", "</I>" );
			t = GlobalFuncs.replacetext( t, "[u]", "<U>" );
			t = GlobalFuncs.replacetext( t, "[/u]", "</U>" );
			t = GlobalFuncs.replacetext( t, "[large]", "<font size=\"4\">" );
			t = GlobalFuncs.replacetext( t, "[/large]", "</font>" );
			if ( user != null ) {
				t = GlobalFuncs.replacetext( t, "[sign]", "<font face=\"" + signfont + "\"><i>" + user.real_name + "</i></font>" );
			} else {
				t = GlobalFuncs.replacetext( t, "[sign]", "" );
			}
			t = GlobalFuncs.replacetext( t, "[field]", "<span class=\"paper_field\"></span>" );
			t = GlobalFuncs.replacetext( t, "[*]", "<li>" );
			t = GlobalFuncs.replacetext( t, "[hr]", "<HR>" );
			t = GlobalFuncs.replacetext( t, "[small]", "<font size = \"1\">" );
			t = GlobalFuncs.replacetext( t, "[/small]", "</font>" );
			t = GlobalFuncs.replacetext( t, "[list]", "<ul>" );
			t = GlobalFuncs.replacetext( t, "[/list]", "</ul>" );
			return t;
		}

		public static dynamic	pick_n_take( UNKNOWN [object Object] =null ) {
			UNKNOWN	picked = null;
			UNKNOWN _default;
			if ( L.len != null ) {
				picked = Rand.Int( 1, L.len );
				undefined = L[picked];
				L.$Cut( picked, picked + 1 );
			}
			return _default;
		}

		public static dynamic	pickweight( UNKNOWN [object Object] =null ) {
			UNKNOWN	total = null;
			total = 0;
			foreach (_ in L ) {
				item = undefined;
				if ( !L[item] != null ) {
					L[item] = 1;
				}
				total += L[item];
			};
			total = Rand.Int( 1, total );
			foreach (_ in L ) {
				item = undefined;
				total -= L[item];
				if ( total <= 0 != null ) {
					return item;
				}
			};
			return;
		}

		public static dynamic	PlaceInPool( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( destroy == null != null ) {
				destroy = 1;
			}
			if ( !( diver instanceof BaseClass ) != null ) {
				return;
			}
			if ( diver in GlobalVars.GlobalPool[diver.type] != null ) {
				return;
			}
			if ( !GlobalVars.GlobalPool[diver.type] != null ) {
				GlobalVars.GlobalPool[diver.type] = new ByTable();
			}
			GlobalVars.GlobalPool[diver.type] = GlobalVars.GlobalPool[diver.type] | diver;
			if ( destroy != null ) {
				diver.Destroy();
			}
			diver.ResetVars();
		}

		public static int	play_vox_word( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	sound_file = null;
			word = GlobalVars.undefined( word );
			if ( GlobalVars.vox_sounds[word] != null ) {
				sound_file = GlobalVars.vox_sounds[word];
				voice = GlobalVars.undefined.lcall( new ByTable().set( "channel", GlobalVars.VOX_CHANNEL ).set( "wait", 1 ).set( 1, sound_file ) );
				voice.status = GlobalVars.SOUND_STREAM;
				if ( !only_listener != null ) {
					M = null;
					foreach (_ in GlobalVars.player_list ) {
						M = undefined;
						if ( M.client && !M.ear_deaf != null ) {
							T = GlobalFuncs.get_turf( M );
							if ( T.z == z_level != null ) {
								M.write( voice );
							}
						}
					};
				} else {
					only_listener.write( voice );
				}
				return 1;
			}
			return 0;
		}

		public static dynamic	playsound( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	frequency = null;
			if ( surround == null != null ) {
				surround = 1;
			}
			soundin = GlobalFuncs.get_sfx( soundin );
			if ( GlobalVars.undefined( source ) != null ) {
				throw new Exception( "playsound(): source is an area", "code/game/sound.dm", 6 );
				return;
			}
			frequency = GlobalFuncs.get_rand_frequency();
			turf_source = GlobalFuncs.get_turf( source );
			P = null;
			foreach (_ in GlobalVars.player_list ) {
				P = undefined;
				M = P;
				if ( !M || !M.client != null ) {
					continue;
				}
				if ( GlobalVars.undefined( M, turf_source ) <= Game.view + extrarange != null ) {
					T = GlobalFuncs.get_turf( M );
					if ( T && T.z == turf_source.z != null ) {
						M.playsound_local( turf_source, soundin, vol, vary, frequency, falloff, surround );
					}
				}
			};
		}

		public static ByTable	pollCandidates( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	candidates = null;
			if ( be_special_flag == null != null ) {
				be_special_flag = 0;
			}
			if ( poll_time == null != null ) {
				poll_time = 300;
			}
			candidates = new ByTable();
			time_passed = Game.time;
			if ( !Question != null ) {
				Question = "Would you like to be a special role?";
			}
			G = null;
			foreach (_ in GlobalVars.player_list ) {
				G = undefined;
				if ( !( G instanceof Mob_Dead_Observer ) != null ) {
					continue;
				}
				if ( !G.key || !G.client != null ) {
					continue;
				}
				if ( be_special_flag != null ) {
					if ( !( G.client.prefs.be_special & be_special_flag ) != null ) {
						continue;
					}
				}
				if ( gametypeCheck != null ) {
					if ( !gametypeCheck.age_check( G.client ) != null ) {
						continue;
					}
				}
				if ( jobbanType != null ) {
					if ( GlobalFuncs.jobban_isbanned( G, jobbanType ) || GlobalFuncs.jobban_isbanned( G, "Syndicate" ) != null ) {
						continue;
					}
				}
				::thread.schedule( 0, function() {
					G.write( new ByRsc(9) );
					local _ = GlobalVars.undefined( G, Question, "Please answer in " + poll_time / 10 + " seconds!", "Yes", "No", null ) // Was a switch-case, sorry for the mess.
					if ( _=="Yes" ) {
						G.write( "<span class='notice'>Choice registered: Yes.</span>" );
						if ( Game.time - time_passed > poll_time != null ) {
							G.write( "<span class='danger'>Sorry, you were too late for the consideration!</span>" );
							G.write( new ByRsc(10) );
							return;
						}
						candidates += G;
					} else if ( _=="No" ) {
						G.write( "<span class='danger'>Choice registered: No.</span>" );
						return;
					} else {
						return;
					};
					return;
				});
			};
			GlobalVars.undefined.sleep( poll_time );
			G = null;
			foreach (_ in candidates ) {
				G = undefined;
				if ( !( G instanceof Mob_Dead_Observer ) != null ) {
					continue;
				}
				if ( !G.key || !G.client != null ) {
					candidates.Remove( G );
				}
			};
			return candidates;
		}

		public static dynamic	PoolOrNew( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( !get_type != null ) {
				return;
			}
			undefined = GlobalFuncs.GetFromPool( get_type, second_arg );
			if ( !undefined != null ) {
				if ( GlobalVars.undefined( get_type ) != null ) {
					if ( second_arg instanceof new List != null ) {
						undefined = get_type.lcall( second_arg );
					} else {
						undefined = get_type( second_arg );
					}
				}
			}
			return _default;
		}

		public static dynamic	pop( UNKNOWN [object Object] =null ) {
			if ( L.len != null ) {
				undefined = L[L.len];
				L.len--;
			}
			return _default;
		}

		public static dynamic	possess( UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			if ( O instanceof Ent_Singularity != null ) {
				if ( GlobalVars.config.forbid_singulo_possession != null ) {
					GlobalVars.undefined.user.write( "It is forbidden to possess singularities." );
					return;
				}
			}
			T = GlobalFuncs.get_turf( O );
			if ( T != null ) {
				GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has possessed " + O + " (" + O.type + ") at (" + T.x + ", " + T.y + ", " + T.z + ")" );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has possessed " + O + " (" + O.type + ") at (" + T.x + ", " + T.y + ", " + T.z + ")" );
			} else {
				GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has possessed " + O + " (" + O.type + ") at an unknown location" );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has possessed " + O + " (" + O.type + ") at an unknown location" );
			}
			if ( !GlobalVars.undefined.user.control_object != null ) {
				GlobalVars.undefined.user.name_archive = GlobalVars.undefined.user.real_name;
			}
			GlobalVars.undefined.user.loc = O;
			GlobalVars.undefined.user.real_name = O.name;
			GlobalVars.undefined.user.name = O.name;
			GlobalVars.undefined.user.client.eye = O;
			GlobalVars.undefined.user.control_object = O;
			GlobalFuncs.feedback_add_details( "admin_verb", "PO" );
		}

		public static dynamic	power_failure(  ) {
			dynamic	S = null;
			GlobalFuncs.priority_announce( "Abnormal activity detected in " + GlobalFuncs._station_name() + "'s powernet. As a precautionary measure, the station's power will be shut off for an indeterminate duration.", "Critical Power Failure", new ByRsc(54) );
			S = null;
			foreach (_ in GlobalVars.machines ) {
				S = undefined;
				if ( !( S instanceof Ent_Machinery_Power_Smes ) != null ) {
					continue;
				}
				if ( GlobalFuncs.get_area( S ) instanceof new ByArea(2739) || S.z != 1 != null ) {
					continue;
				}
				S.charge = 0;
				S.output_level = 0;
				S.output_attempt = 0;
				S.$update icon();
				S.$power change();
			};
			skipped_areas = new ByTable(new object [] {new ByArea(2719),new ByArea(2727)});
			A = null;
			foreach (_ in Game ) {
				A = undefined;
				if ( !A.requires_power || A.always_unpowered != null ) {
					continue;
				}
				skip = 0;
				area_type = null;
				foreach (_ in skipped_areas ) {
					area_type = undefined;
					if ( A instanceof area_type != null ) {
						skip = 1;
						break;
					}
				};
				if ( A.contents != null ) {
					AT = null;
					foreach (_ in A.contents ) {
						AT = undefined;
						if ( !( AT instanceof BaseStatic ) != null ) {
							continue;
						}
						if ( AT.z != 1 != null ) {
							skip = 1;
						}
						break;
					};
				}
				if ( skip != null ) {
					continue;
				}
				A.power_light = 0;
				A.power_equip = 0;
				A.power_environ = 0;
				A.power_change();
			};
			C = null;
			foreach (_ in GlobalVars.apcs_list ) {
				C = undefined;
				if ( !( C instanceof Ent_Machinery_Power_Apc ) != null ) {
					continue;
				}
				if ( C.cell && C.z == 1 != null ) {
					A = GlobalFuncs.get_area( C );
					skip = 0;
					area_type = null;
					foreach (_ in skipped_areas ) {
						area_type = undefined;
						if ( A instanceof area_type != null ) {
							skip = 1;
							break;
						}
					};
					if ( skip != null ) {
						continue;
					}
					C.cell.charge = 0;
				}
			};
		}

		public static dynamic	power_list( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	AM = null;
			UNKNOWN _default;
			if ( unmarked == null != null ) {
				unmarked = 0;
			}
			if ( cable_only == null != null ) {
				cable_only = 0;
			}
			undefined = new ByTable();
			AM = null;
			foreach (_ in T ) {
				AM = undefined;
				if ( AM == source != null ) {
					continue;
				}
				if ( !cable_only && AM instanceof Ent_Machinery_Power != null ) {
					P = AM;
					if ( P.powernet == 0 != null ) {
						continue;
					}
					if ( !unmarked || !P.powernet != null ) {
						if ( d == 0 != null ) {
							undefined += P;
						}
					}
				} else if ( AM instanceof Ent_Structure_Cable != null ) {
					C = AM;
					if ( !unmarked || !C.powernet != null ) {
						if ( C.d1 == d || C.d2 == d != null ) {
							undefined += C;
						}
					}
				}
			};
			return undefined;
			return _default;
		}

		public static dynamic	power_restore(  ) {
			dynamic	C = null;
			GlobalFuncs.priority_announce( "Power has been restored to " + GlobalFuncs._station_name() + ". We apologize for the inconvenience.", "Power Systems Nominal", new ByRsc(55) );
			C = null;
			foreach (_ in GlobalVars.machines ) {
				C = undefined;
				if ( !( C instanceof Ent_Machinery_Power_Apc ) != null ) {
					continue;
				}
				if ( C.cell && C.z == 1 != null ) {
					C.charge = C.cell.maxcharge;
				}
			};
			S = null;
			foreach (_ in GlobalVars.machines ) {
				S = undefined;
				if ( !( S instanceof Ent_Machinery_Power_Smes ) != null ) {
					continue;
				}
				if ( S.z != 1 != null ) {
					continue;
				}
				S.charge = S.capacity;
				S.output_level = S.output_level_max;
				S.output_attempt = 1;
				S.$update icon();
				S.$power change();
			};
			A = null;
			foreach (_ in Game ) {
				A = undefined;
				if ( !( A instanceof new ByArea(2717) ) && !( A instanceof new ByArea(2755) ) && !( A instanceof new ByArea(2741) ) != null ) {
					A.power_light = 1;
					A.power_equip = 1;
					A.power_environ = 1;
					A.power_change();
				}
			};
		}

		public static dynamic	power_restore_quick(  ) {
			dynamic	S = null;
			GlobalFuncs.priority_announce( "All SMESs on " + GlobalFuncs._station_name() + " have been recharged. We apologize for the inconvenience.", "Power Systems Nominal", new ByRsc(55) );
			S = null;
			foreach (_ in GlobalVars.machines ) {
				S = undefined;
				if ( !( S instanceof Ent_Machinery_Power_Smes ) != null ) {
					continue;
				}
				if ( S.z != 1 != null ) {
					continue;
				}
				S.charge = S.capacity;
				S.output_level = S.output_level_max;
				S.output_attempt = 1;
				S.$update icon();
				S.$power change();
			};
		}

		public static string	pretty_string_from_reagent_list( UNKNOWN [object Object] =null ) {
			string	result = null;
			result = "| ";
			R = null;
			foreach (_ in reagent_list ) {
				R = undefined;
				if ( !( R instanceof Reagent ) != null ) {
					continue;
				}
				result += "" + R.name + ", " + R.volume + " | ";
			};
			return result;
		}

		public static UNKNOWN	previous_list_item( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	i = null;
			i = L.Find( item );
			if ( i == 1 != null ) {
				i = L.len;
			} else {
				i--;
			}
			return L[i];
		}

		public static dynamic	print_command_report( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	C = null;
			if ( text == null != null ) {
				text = "";
			}
			if ( title == null != null ) {
				title = "Central Command Update";
			}
			C = null;
			foreach (_ in GlobalVars.machines ) {
				C = undefined;
				if ( !( C instanceof Ent_Machinery_Computer_Communications ) != null ) {
					continue;
				}
				if ( !( C.stat & 3 ) && C.z == 1 != null ) {
					P = new Ent_Item_Weapon_Paper( C.loc );
					P.name = "paper- '" + title + "'";
					P.info = text;
					C.messagetitle.Add( "" + title );
					C.messagetext.Add( text );
				}
			};
		}

		public static dynamic	priority_announce( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	announcement = null;
			if ( title == null != null ) {
				title = "";
			}
			if ( sound == null != null ) {
				sound = new ByRsc(62);
			}
			if ( !text != null ) {
				return;
			}
			if ( type == "Priority" != null ) {
				announcement += "<h1 class='alert'>Priority Announcement</h1>";
				if ( title && GlobalVars.undefined( title ) > 0 != null ) {
					announcement += "<br><h2 class='alert'>" + GlobalVars.undefined( title ) + "</h2>";
				}
			} else if ( type == "Captain" != null ) {
				announcement += "<h1 class='alert'>Captain Announces</h1>";
				GlobalVars.news_network.SubmitArticle( text, "Captain's Announcement", "Station Announcements", null );
			} else {
				announcement += "<h1 class='alert'>" + GlobalFuncs._command_name() + " Update</h1>";
				if ( title && GlobalVars.undefined( title ) > 0 != null ) {
					announcement += "<br><h2 class='alert'>" + GlobalVars.undefined( title ) + "</h2>";
				}
				if ( title == "" != null ) {
					GlobalVars.news_network.SubmitArticle( text, "Central Command Update", "Station Announcements", null );
				} else {
					GlobalVars.news_network.SubmitArticle( title + "<br><br>" + text, "Central Command", "Station Announcements", null );
				}
			}
			announcement += "<br><span class='alert'>" + GlobalVars.undefined( text ) + "</span><br>";
			announcement += "<br>";
			M = null;
			foreach (_ in GlobalVars.player_list ) {
				M = undefined;
				if ( !( M instanceof Mob_NewPlayer ) && !M.ear_deaf != null ) {
					M.write( announcement );
					M.write( Sound( sound ) );
				}
			};
		}

		public static ProjectileData	projectile_trajectory( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	power_x = null;
			power_x = power * GlobalVars.undefined.cos( angle );
			power_y = power * GlobalVars.undefined.sin( angle );
			time = power_y * 2 / 10;
			distance = time * power_x;
			dest_x = src_x + distance * GlobalVars.undefined.sin( rotation );
			dest_y = src_y + distance * GlobalVars.undefined.cos( rotation );
			return new ProjectileData( src_x, src_y, time, distance, power_x, power_y, dest_x, dest_y );
		}

		public static dynamic	propagate_network( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	worklist = null;
			worklist = new ByTable();
			found_machines = new ByTable();
			index = 1;
			P = null;
			worklist += O;
			while (index <= worklist.len) {
				P = worklist[index];
				index++;
				if ( P instanceof Ent_Structure_Cable != null ) {
					C = P;
					if ( C.powernet != PN != null ) {
						PN.add_cable( C );
					}
					worklist = worklist | C.get_connections();
				} else if ( P.anchored && P instanceof Ent_Machinery_Power != null ) {
					M = P;
					found_machines = found_machines | M;
				} else {
					continue;
				}
			};
			PM = null;
			foreach (_ in found_machines ) {
				PM = undefined;
				if ( !( PM instanceof Ent_Machinery_Power ) != null ) {
					continue;
				}
				if ( !PM.connect_to_network() != null ) {
					PM.disconnect_from_network();
				}
			};
		}

		public static dynamic	qdel( UNKNOWN [object Object] =null ) {
			UNKNOWN	hint = null;
			if ( !A != null ) {
				return;
			}
			if ( !( A instanceof BaseClass ) != null ) {
				GlobalVars.undefined( A );
				A = null;
			} else if ( GlobalVars.undefined( A.gc_destroyed ) != null ) {
				hint = A.$Destroy();
				if ( !A != null ) {
					return;
				}
				local _ = hint // Was a switch-case, sorry for the mess.
				if ( _==0 ) {
					GlobalVars.SSgarbage.Queue( A );
				} else if ( _==1 ) {
					return;
				} else if ( _==2 ) {
					return;
				} else if ( _==3 ) {
					GlobalVars.SSgarbage.HardQueue( A );
				} else if ( _==4 ) {
					GlobalVars.undefined( A );
					A = null;
				} else if ( _==5 ) {
					GlobalFuncs.PlaceInPool( A, 0 );
				} else if ( _==6 ) {
					GlobalVars.SSgarbage.Queue( A );
				} else {
					if ( !( "" + A.type in GlobalVars.SSgarbage.noqdelhint ) != null ) {
						GlobalVars.SSgarbage.noqdelhint += "" + A.type;
						GlobalFuncs.testing( "WARNING: " + A.type + " is not returning a qdel hint. It is being placed in the queue. Further instances of this type will also be queued." );
					}
					GlobalVars.SSgarbage.Queue( A );
				};
			}
		}

		public static int	qdeleted( UNKNOWN [object Object] =null ) {
			if ( !( A instanceof BaseClass ) != null ) {
				return 0;
			}
			if ( A.gc_destroyed != null ) {
				return 1;
			}
			return 0;
		}

		public static int	radiation_pulse( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	light_severity = null;
			if ( log == null != null ) {
				log = 0;
			}
			if ( !epicenter || !severity != null ) {
				return;
			}
			if ( !( epicenter instanceof Tile ) != null ) {
				epicenter = GlobalFuncs.get_turf( epicenter.loc );
			}
			if ( log != null ) {
				GlobalFuncs.message_admins( "Radiation pulse with size (" + heavy_range + ", " + light_range + ") and severity " + severity + " in area " + epicenter.loc.name + " " );
				GlobalFuncs.log_game( "Radiation pulse with size (" + heavy_range + ", " + light_range + ") and severity " + severity + " in area " + epicenter.loc.name + " " );
			}
			if ( heavy_range > light_range != null ) {
				light_range = heavy_range;
			}
			light_severity = severity * 0.5;
			T = null;
			foreach (_ in GlobalVars.undefined( light_range, epicenter ) ) {
				T = undefined;
				if ( !( T instanceof BaseStatic ) != null ) {
					continue;
				}
				distance = GlobalVars.undefined( epicenter, T );
				if ( distance < 0 != null ) {
					distance = 0;
				}
				if ( distance < heavy_range != null ) {
					T.rad_act( severity );
				} else if ( distance == heavy_range != null ) {
					if ( Rand.chance( 50 ) != null ) {
						T.rad_act( severity );
					} else {
						T.rad_act( light_severity );
					}
				} else if ( distance <= light_range != null ) {
					T.rad_act( light_severity );
				}
			};
			return 1;
		}

		public static UNKNOWN	ran_zone( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	t = null;
			if ( probability == null != null ) {
				probability = 80;
			}
			zone = GlobalFuncs.check_zone( zone );
			if ( Rand.chance( probability ) != null ) {
				return zone;
			}
			t = Rand.Int( 1, 18 );
			local _ = t // Was a switch-case, sorry for the mess.
			if ( 3<=_&&_<=6 ) {
				return "l_arm";
			} else if ( 7<=_&&_<=10 ) {
				return "r_arm";
			} else if ( 11<=_&&_<=14 ) {
				return "l_leg";
			} else if ( 15<=_&&_<=18 ) {
				return "r_leg";
			} else if ( _==1 ) {
				return "head";
			} else if ( _==2 ) {
				return "chest";
			};
			return zone;
		}

		public static dynamic	randmut( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	num = null;
			UNKNOWN _default;
			if ( difficulty == null != null ) {
				difficulty = 2;
			}
			if ( !M.has_dna() != null ) {
				return;
			}
			num = Rand.pick( candidates );
			undefined = num.force_give( M );
			return;
			return _default;
		}

		public static dynamic	randmutb( UNKNOWN [object Object] =null ) {
			UNKNOWN	HM = null;
			UNKNOWN _default;
			if ( !M.has_dna() != null ) {
				return;
			}
			HM = Rand.pick( ( GlobalVars.bad_mutations | GlobalVars.not_good_mutations ) - GlobalVars.mutations_list.Monkified );
			undefined = HM.force_give( M );
			return _default;
		}

		public static dynamic	randmutg( UNKNOWN [object Object] =null ) {
			UNKNOWN	HM = null;
			UNKNOWN _default;
			if ( !M.has_dna() != null ) {
				return;
			}
			HM = Rand.pick( GlobalVars.good_mutations );
			undefined = HM.force_give( M );
			return _default;
		}

		public static dynamic	randmuti( UNKNOWN [object Object] =null ) {
			UNKNOWN	num = null;
			if ( !M.has_dna() != null ) {
				return;
			}
			num = Rand.Int( 1, 7 );
			newdna = GlobalFuncs.setblock( M.dna.uni_identity, num, GlobalFuncs.random_string( 3, GlobalVars.hex_characters ) );
			M.dna.uni_identity = newdna;
			return;
		}

		public static UNKNOWN	random_blood_type(  ) {
			return int _ = Rand.Int(0,65535) // Was a weighted pick, sorry for the mess.
	<-REP->if ( _ < 2674 ) { _ = "O-" }
	<-REP->else if ( _ < 26748 ) { _ = "O+" }
	<-REP->else if ( _ < 28754 ) { _ = "A-" }
	<-REP->else if ( _ < 47478 ) { _ = "A+" }
	<-REP->else if ( _ < 48146 ) { _ = "B-" }
	<-REP->else if ( _ < 61520 ) { _ = "B+" }
	<-REP->else if ( _ < 62188 ) { _ = "AB-" }
	<-REP->else  { _ = "AB+" };
		}

		public static UNKNOWN	random_eye_color(  ) {
			local _ = int _ = Rand.Int(0,65535) // Was a weighted pick, sorry for the mess.
	<-REP->if ( _ < 14246 ) { _ = "brown" }
	<-REP->else if ( _ < 28492 ) { _ = "hazel" }
	<-REP->else if ( _ < 42738 ) { _ = "grey" }
	<-REP->else if ( _ < 53423 ) { _ = "blue" }
	<-REP->else if ( _ < 64108 ) { _ = "green" }
	<-REP->else if ( _ < 64820 ) { _ = "amber" }
	<-REP->else  { _ = "albino" } // Was a switch-case, sorry for the mess.
			if ( _=="brown" ) {
				return "630";
			} else if ( _=="hazel" ) {
				return "542";
			} else if ( _=="grey" ) {
				return Rand.pick(new object [] { "666", "777", "888", "999", "aaa", "bbb", "ccc" });
			} else if ( _=="blue" ) {
				return "36c";
			} else if ( _=="green" ) {
				return "060";
			} else if ( _=="amber" ) {
				return "fc0";
			} else if ( _=="albino" ) {
				return Rand.pick(new object [] { "c", "d", "e", "f" }) + Rand.pick(new object [] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }) + Rand.pick(new object [] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
			} else {
				return "000";
			};
		}

		public static UNKNOWN	random_facial_hair_style( UNKNOWN [object Object] =null ) {
			local _ = gender // Was a switch-case, sorry for the mess.
			if ( _=="male" ) {
				return Rand.pick( GlobalVars.facial_hair_styles_male_list );
			} else if ( _=="female" ) {
				return Rand.pick( GlobalVars.facial_hair_styles_female_list );
			} else {
				return Rand.pick( GlobalVars.facial_hair_styles_list );
			};
		}

		public static ByTable	random_features(  ) {
			if ( !GlobalVars.tails_list_human.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Tails_Human, GlobalVars.tails_list_human );
			}
			if ( !GlobalVars.tails_list_lizard.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Tails_Lizard, GlobalVars.tails_list_lizard );
			}
			if ( !GlobalVars.snouts_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Snouts, GlobalVars.snouts_list );
			}
			if ( !GlobalVars.horns_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Horns, GlobalVars.horns_list );
			}
			if ( !GlobalVars.ears_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Ears, GlobalVars.horns_list );
			}
			if ( !GlobalVars.frills_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Frills, GlobalVars.frills_list );
			}
			if ( !GlobalVars.spines_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Spines, GlobalVars.spines_list );
			}
			if ( !GlobalVars.body_markings_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_BodyMarkings, GlobalVars.body_markings_list );
			}
			return new ByTable().set( "body_markings", Rand.pick( GlobalVars.body_markings_list ) ).set( "spines", Rand.pick( GlobalVars.spines_list ) ).set( "frills", Rand.pick( GlobalVars.frills_list ) ).set( "ears", "None" ).set( "horns", Rand.pick( GlobalVars.horns_list ) ).set( "snout", Rand.pick( GlobalVars.snouts_list ) ).set( "tail_human", "None" ).set( "tail_lizard", Rand.pick( GlobalVars.tails_list_lizard ) ).set( "mcolor", Rand.pick(new object [] { "FFFFFF", "7F7F7F", "7FFF7F", "7F7FFF", "FF7F7F", "7FFFFF", "FF7FFF", "FFFF7F" }) );
		}

		public static UNKNOWN	random_hair_style( UNKNOWN [object Object] =null ) {
			local _ = gender // Was a switch-case, sorry for the mess.
			if ( _=="male" ) {
				return Rand.pick( GlobalVars.hair_styles_male_list );
			} else if ( _=="female" ) {
				return Rand.pick( GlobalVars.hair_styles_female_list );
			} else {
				return Rand.pick( GlobalVars.hair_styles_list );
			};
		}

		public static UNKNOWN	random_short_color(  ) {
			return GlobalFuncs.random_string( 3, GlobalVars.hex_characters );
		}

		public static UNKNOWN	random_skin_tone(  ) {
			return Rand.pick( GlobalVars.skin_tones );
		}

		public static UNKNOWN	random_socks( UNKNOWN [object Object] =null ) {
			if ( !GlobalVars.socks_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Socks, GlobalVars.socks_list, GlobalVars.socks_m, GlobalVars.socks_f );
			}
			local _ = gender // Was a switch-case, sorry for the mess.
			if ( _=="male" ) {
				return Rand.pick( GlobalVars.socks_m );
			} else if ( _=="female" ) {
				return Rand.pick( GlobalVars.socks_f );
			} else {
				return Rand.pick( GlobalVars.socks_list );
			};
		}

		public static dynamic	random_step( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	initial_chance = null;
			initial_chance = chance;
			while (steps > 0) {
				if ( Rand.chance( chance ) != null ) {
					GlobalVars.undefined( AM, Rand.pick( GlobalVars.alldirs ) );
				}
				chance = GlobalVars.undefined.max( chance - initial_chance / steps, 0 );
				steps--;
			};
		}

		public static dynamic	random_string( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			undefined = "";
			i = null;
			i = 1;
			while (i <= length) {
				undefined += Rand.pick( characters );
				i++;
			};
			return _default;
		}

		public static UNKNOWN	random_undershirt( UNKNOWN [object Object] =null ) {
			if ( !GlobalVars.undershirt_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Undershirt, GlobalVars.undershirt_list, GlobalVars.undershirt_m, GlobalVars.undershirt_f );
			}
			local _ = gender // Was a switch-case, sorry for the mess.
			if ( _=="male" ) {
				return Rand.pick( GlobalVars.undershirt_m );
			} else if ( _=="female" ) {
				return Rand.pick( GlobalVars.undershirt_f );
			} else {
				return Rand.pick( GlobalVars.undershirt_list );
			};
		}

		public static UNKNOWN	random_underwear( UNKNOWN [object Object] =null ) {
			if ( !GlobalVars.underwear_list.len != null ) {
				GlobalFuncs.init_sprite_accessory_subtypes( SpriteAccessory_Underwear, GlobalVars.underwear_list, GlobalVars.underwear_m, GlobalVars.underwear_f );
			}
			local _ = gender // Was a switch-case, sorry for the mess.
			if ( _=="male" ) {
				return Rand.pick( GlobalVars.underwear_m );
			} else if ( _=="female" ) {
				return Rand.pick( GlobalVars.underwear_f );
			} else {
				return Rand.pick( GlobalVars.underwear_list );
			};
		}

		public static dynamic	random_unique_lizard_name( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			if ( attempts_to_find_unique_name == null != null ) {
				attempts_to_find_unique_name = 10;
			}
			i = null;
			i = 1;
			while (i <= attempts_to_find_unique_name) {
				undefined = GlobalFuncs.capitalize( GlobalFuncs.lizard_name( gender ) );
				if ( i != attempts_to_find_unique_name && !GlobalFuncs.findname( undefined ) != null ) {
					break;
				}
				i++;
			};
			return _default;
		}

		public static dynamic	random_unique_name( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			if ( attempts_to_find_unique_name == null != null ) {
				attempts_to_find_unique_name = 10;
			}
			i = null;
			i = 1;
			while (i <= attempts_to_find_unique_name) {
				if ( gender == GlobalVars.FEMALE != null ) {
					undefined = GlobalFuncs.capitalize( Rand.pick( GlobalVars.first_names_female ) ) + " " + GlobalFuncs.capitalize( Rand.pick( GlobalVars.last_names ) );
				} else {
					undefined = GlobalFuncs.capitalize( Rand.pick( GlobalVars.first_names_male ) ) + " " + GlobalFuncs.capitalize( Rand.pick( GlobalVars.last_names ) );
				}
				if ( i != attempts_to_find_unique_name && !GlobalFuncs.findname( undefined ) != null ) {
					break;
				}
				i++;
			};
			return _default;
		}

		public static UNKNOWN	randomColor( UNKNOWN [object Object] =null ) {
			if ( mode == null != null ) {
				mode = 0;
			}
			local _ = mode // Was a switch-case, sorry for the mess.
			if ( _==0 ) {
				return Rand.pick(new object [] { "white", "black", "gray", "red", "green", "blue", "brown", "yellow", "orange", "darkred", "crimson", "lime", "darkgreen", "cyan", "navy", "teal", "purple", "indigo" });
			} else if ( _==1 ) {
				return Rand.pick(new object [] { "red", "green", "blue", "brown", "yellow", "orange", "darkred", "crimson", "lime", "darkgreen", "cyan", "navy", "teal", "purple", "indigo" });
			} else {
				return "white";
			};
		}

		public static dynamic	randomize_human( UNKNOWN [object Object] =null ) {
			H.gender = Rand.pick(new object [] { GlobalVars.MALE, GlobalVars.FEMALE });
			H.real_name = GlobalFuncs.random_unique_name( H.gender );
			H.name = H.real_name;
			H.underwear = GlobalFuncs.random_underwear( H.gender );
			H.skin_tone = GlobalFuncs.random_skin_tone();
			H.hair_style = GlobalFuncs.random_hair_style( H.gender );
			H.facial_hair_style = GlobalFuncs.random_facial_hair_style( H.gender );
			H.hair_color = GlobalFuncs.random_short_color();
			H.facial_hair_color = H.hair_color;
			H.eye_color = GlobalFuncs.random_eye_color();
			H.dna.blood_type = GlobalFuncs.random_blood_type();
			H.update_body();
			H.$update hair();
		}

		public static dynamic	ReadHSV( UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			if ( !hsv != null ) {
				return;
			}
			i = 1;
			start = 1;
			if ( GlobalVars.undefined( hsv, null ) == 35 != null ) {
				start++;
			}
			which = 0;
			hue = 0;
			sat = 0;
			val = 0;
			alpha = 0;
			digits = 0;
			i = start;
			while (i <= GlobalVars.undefined( hsv )) {
				ch = GlobalVars.undefined( hsv, i );
				if ( ch < 48 || ch > 57 && ch < 65 || ch > 70 && ch < 97 || ch > 102 != null ) {
					break;
				}
				digits++;
				if ( digits == 9 != null ) {
					break;
				}
				i++;
			};
			if ( digits > 7 != null ) {
				usealpha = 1;
			}
			if ( digits <= 4 != null ) {
				which++;
			}
			if ( digits <= 2 != null ) {
				which++;
			}
			i = start;
			while (digits > 0) {
				ch = GlobalVars.undefined( hsv, i );
				if ( ch >= 48 && ch <= 57 != null ) {
					ch -= 48;
				} else if ( ch >= 65 && ch <= 70 != null ) {
					ch -= 55;
				} else if ( ch >= 97 && ch <= 102 != null ) {
					ch -= 87;
				} else {
					break;
				}
				digits--;
				local _ = which // Was a switch-case, sorry for the mess.
				if ( _==0 ) {
					hue = hue << 4 | ch;
					if ( digits == ( usealpha ? 6 : 4 ) != null ) {
						which++;
					}
				} else if ( _==1 ) {
					sat = sat << 4 | ch;
					if ( digits == ( usealpha ? 4 : 2 ) != null ) {
						which++;
					}
				} else if ( _==2 ) {
					val = val << 4 | ch;
					if ( digits == ( usealpha ? 2 : 0 ) != null ) {
						which++;
					}
				} else if ( _==3 ) {
					alpha = alpha << 4 | ch;
				};
				i++;
			};
			undefined = new ByTable(new object [] {hue,sat,val});
			if ( usealpha != null ) {
				undefined += alpha;
			}
			return _default;
		}

		public static dynamic	ReadRGB( UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			if ( !rgb != null ) {
				return;
			}
			i = 1;
			start = 1;
			if ( GlobalVars.undefined( rgb, null ) == 35 != null ) {
				start++;
			}
			which = 0;
			r = 0;
			g = 0;
			b = 0;
			alpha = 0;
			digits = 0;
			i = start;
			while (i <= GlobalVars.undefined( rgb )) {
				ch = GlobalVars.undefined( rgb, i );
				if ( ch < 48 || ch > 57 && ch < 65 || ch > 70 && ch < 97 || ch > 102 != null ) {
					break;
				}
				digits++;
				if ( digits == 8 != null ) {
					break;
				}
				i++;
			};
			single = digits < 6;
			if ( digits != 3 && digits != 4 && digits != 6 && digits != 8 != null ) {
				return;
			}
			if ( digits == 4 || digits == 8 != null ) {
				usealpha = 1;
			}
			i = start;
			while (digits > 0) {
				ch = GlobalVars.undefined( rgb, i );
				if ( ch >= 48 && ch <= 57 != null ) {
					ch -= 48;
				} else if ( ch >= 65 && ch <= 70 != null ) {
					ch -= 55;
				} else if ( ch >= 97 && ch <= 102 != null ) {
					ch -= 87;
				} else {
					break;
				}
				digits--;
				local _ = which // Was a switch-case, sorry for the mess.
				if ( _==0 ) {
					r = r << 4 | ch;
					if ( single != null ) {
						r = r | r << 4;
						which++;
					} else if ( !( digits & 1 ) != null ) {
						which++;
					}
				} else if ( _==1 ) {
					g = g << 4 | ch;
					if ( single != null ) {
						g = g | g << 4;
						which++;
					} else if ( !( digits & 1 ) != null ) {
						which++;
					}
				} else if ( _==2 ) {
					b = b << 4 | ch;
					if ( single != null ) {
						b = b | b << 4;
						which++;
					} else if ( !( digits & 1 ) != null ) {
						which++;
					}
				} else if ( _==3 ) {
					alpha = alpha << 4 | ch;
					if ( single != null ) {
						alpha = alpha | alpha << 4;
					}
				};
				i++;
			};
			undefined = new ByTable(new object [] {r,g,b});
			if ( usealpha != null ) {
				undefined += alpha;
			}
			return _default;
		}

		public static UNKNOWN	recursive_hear_check( UNKNOWN [object Object] =null ) {
			UNKNOWN	processing_list = null;
			processing_list = new ByTable(new object [] {O});
			processed_list = new ByTable();
			found_atoms = new ByTable();
			while (processing_list.len) {
				A = processing_list[1];
				if ( A.flags & 16 != null ) {
					found_atoms = found_atoms | A;
				}
				B = null;
				foreach (_ in A ) {
					B = undefined;
					if ( !( B instanceof BaseStatic ) != null ) {
						continue;
					}
					if ( !processed_list[B] != null ) {
						processing_list = processing_list | B;
					}
				};
				processing_list.Cut( 1, 2 );
				processed_list[A] = A;
			};
			return found_atoms;
		}

		public static UNKNOWN	recursive_mob_check( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	processing_list = null;
			if ( client_check == null != null ) {
				client_check = 1;
			}
			if ( sight_check == null != null ) {
				sight_check = 1;
			}
			if ( include_radio == null != null ) {
				include_radio = 1;
			}
			processing_list = new ByTable(new object [] {O});
			processed_list = new ByTable();
			found_mobs = new ByTable();
			while (processing_list.len) {
				A = processing_list[1];
				passed = 0;
				if ( GlobalVars.undefined( A ) != null ) {
					A_tmp = A;
					passed = 1;
					if ( client_check && !A_tmp.client != null ) {
						passed = 0;
					}
					if ( sight_check && !GlobalFuncs.isInSight( A_tmp, O ) != null ) {
						passed = 0;
					}
				} else if ( include_radio && A instanceof Ent_Item_Device_Radio != null ) {
					passed = 1;
					if ( sight_check && !GlobalFuncs.isInSight( A, O ) != null ) {
						passed = 0;
					}
				}
				if ( passed != null ) {
					found_mobs = found_mobs | A;
				}
				B = null;
				foreach (_ in A ) {
					B = undefined;
					if ( !( B instanceof BaseStatic ) != null ) {
						continue;
					}
					if ( !processed_list[B] != null ) {
						processing_list = processing_list | B;
					}
				};
				processing_list.Cut( 1, 2 );
				processed_list[A] = A;
			};
			return found_mobs;
		}

		public static Regex	regex_find( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return new Regex( str, exp, GlobalVars.undefined( "bin/bygex", "regex_find" )( str, exp ) );
		}

		public static Regex	regex_note_sql_extract( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return new Regex( str, exp, GlobalVars.undefined( "bin/bygex", "regEx_find" )( str, exp ) );
		}

		public static UNKNOWN	reject_bad_name( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	number_of_alphanumeric = null;
			if ( allow_numbers == null != null ) {
				allow_numbers = 0;
			}
			if ( max_length == null != null ) {
				max_length = 26;
			}
			if ( !t_in || GlobalVars.undefined( t_in ) > max_length != null ) {
				return;
			}
			number_of_alphanumeric = 0;
			last_char_group = 0;
			t_out = "";
			i = null;
			i = 1;
			while (i <= GlobalVars.undefined( t_in )) {
				ascii_char = GlobalVars.undefined( t_in, i );
				local _ = ascii_char // Was a switch-case, sorry for the mess.
				if ( 65<=_&&_<=90 ) {
					t_out += GlobalVars.undefined( ascii_char );
					number_of_alphanumeric++;
					last_char_group = 4;
				} else if ( 97<=_&&_<=122 ) {
					if ( last_char_group < 2 != null ) {
						t_out += GlobalVars.undefined( ascii_char - 32 );
					} else {
						t_out += GlobalVars.undefined( ascii_char );
					}
					number_of_alphanumeric++;
					last_char_group = 4;
				} else if ( 48<=_&&_<=57 ) {
					if ( !last_char_group != null ) {
						i++;
						continue;
					}
					if ( !allow_numbers != null ) {
						i++;
						continue;
					}
					t_out += GlobalVars.undefined( ascii_char );
					number_of_alphanumeric++;
					last_char_group = 3;
				} else if ( _==39 || _==45 || _==46 ) {
					if ( !last_char_group != null ) {
						i++;
						continue;
					}
					t_out += GlobalVars.undefined( ascii_char );
					last_char_group = 2;
				} else if ( _==126 || _==124 || _==64 || _==58 || _==35 || _==36 || _==37 || _==38 || _==42 || _==43 ) {
					if ( !last_char_group != null ) {
						i++;
						continue;
					}
					if ( !allow_numbers != null ) {
						i++;
						continue;
					}
					t_out += GlobalVars.undefined( ascii_char );
					last_char_group = 2;
				} else if ( _==32 ) {
					if ( last_char_group <= 1 != null ) {
						i++;
						continue;
					}
					t_out += GlobalVars.undefined( ascii_char );
					last_char_group = 1;
				} else {
					return;
				};
				i++;
			};
			if ( number_of_alphanumeric < 2 != null ) {
				return;
			}
			if ( last_char_group == 1 != null ) {
				t_out = GlobalVars.undefined( t_out, 1, GlobalVars.undefined( t_out ) );
			}
			bad_name = null;
			foreach (_ in new ByTable(new object [] {"space","floor","wall","r-wall","monkey","unknown","inactive ai"}) ) {
				bad_name = undefined;
				if ( GlobalVars.undefined( bad_name, t_out ) != null ) {
					return;
				}
			};
			return t_out;
		}

		public static dynamic	reject_bad_text( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	non_whitespace = null;
			if ( max_length == null != null ) {
				max_length = 512;
			}
			if ( GlobalVars.undefined( text ) > max_length != null ) {
				return;
			}
			non_whitespace = 0;
			i = null;
			i = 1;
			while (i <= GlobalVars.undefined( text )) {
				local _ = GlobalVars.undefined( text, i ) // Was a switch-case, sorry for the mess.
				if ( 127<=_&&_<=255 ) {
					return;
				} else if ( 0<=_&&_<=31 ) {
					return;
				} else if ( _==62 || _==60 || _==92 || _==47 ) {
					return;
				} else if ( _==32 ) {
					i++;
					continue;
				} else {
					non_whitespace = 1;
				};
				i++;
			};
			if ( non_whitespace != null ) {
				return text;
			}
		}

		public static dynamic	release( UNKNOWN [object Object] =null ) {
			UNKNOWN	H = null;
			if ( GlobalVars.undefined.user.control_object && GlobalVars.undefined.user.name_archive != null ) {
				GlobalVars.undefined.user.real_name = GlobalVars.undefined.user.name_archive;
				GlobalVars.undefined.user.name = GlobalVars.undefined.user.real_name;
				if ( GlobalVars.undefined.user instanceof Mob_Living_Carbon_Human != null ) {
					H = GlobalVars.undefined.user;
					H.name = H.get_visible_name();
				}
			}
			GlobalVars.undefined.user.loc = O.loc;
			GlobalVars.undefined.user.client.eye = GlobalVars.undefined.user;
			GlobalVars.undefined.user.control_object = null;
			GlobalFuncs.feedback_add_details( "admin_verb", "RO" );
		}

		public static dynamic	remove_note( UNKNOWN [object Object] =null ) {
			UNKNOWN	ckey = null;
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalVars.undefined.user.write( "<span class='danger'>Failed to establish database connection.</span>" );
				return;
			}
			if ( !note_id != null ) {
				return;
			}
			note_id = GlobalVars.undefined( note_id );
			query_find_note_del = GlobalVars.dbcon.NewQuery( "SELECT ckey, notetext, adminckey FROM " + GlobalFuncs.format_table_name( "notes" ) + " WHERE id = " + note_id );
			if ( !query_find_note_del.Execute() != null ) {
				err = query_find_note_del.$ErrorMsg();
				GlobalFuncs.log_game( "SQL ERROR obtaining ckey, notetext, adminckey from notes table. Error : [" + err + "]\n" );
				return;
			}
			if ( query_find_note_del.NextRow() != null ) {
				ckey = query_find_note_del.item[1];
				notetext = query_find_note_del.item[2];
				adminckey = query_find_note_del.item[3];
			}
			query_del_note = GlobalVars.dbcon.NewQuery( "DELETE FROM " + GlobalFuncs.format_table_name( "notes" ) + " WHERE id = " + note_id );
			if ( !query_del_note.Execute() != null ) {
				err = query_del_note.$ErrorMsg();
				GlobalFuncs.log_game( "SQL ERROR removing note from table. Error : [" + err + "]\n" );
				return;
			}
			GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has removed a note made by " + adminckey + " from " + ckey + ": " + notetext );
			GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " has removed a note made by " + adminckey + " from " + ckey + ":<br>" + notetext );
			GlobalFuncs.show_note( ckey );
		}

		public static dynamic	remove_radio( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( !freq || !radio != null ) {
				return;
			}
			if ( !GlobalVars.all_radios["" + freq] != null ) {
				return;
			}
			GlobalVars.all_radios["" + freq] -= radio;
		}

		public static dynamic	remove_radio_all( UNKNOWN [object Object] =null ) {
			dynamic	freq = null;
			freq = null;
			foreach (_ in GlobalVars.all_radios ) {
				freq = undefined;
				GlobalVars.all_radios["" + freq] -= radio;
			};
		}

		public static int	RemoveBan( UNKNOWN [object Object] =null ) {
			UNKNOWN	key = null;
			GlobalVars.Banlist.cd = "/base/" + foldername;
			key = GlobalVars.Banlist.key._GOOFY_LIST_.read();
			id = GlobalVars.Banlist.id._GOOFY_LIST_.read();
			GlobalVars.Banlist.cd = "/base";
			if ( !GlobalVars.Banlist.dir.Remove( foldername ) != null ) {
				return 0;
			}
			if ( !GlobalVars.undefined.user != null ) {
				GlobalFuncs.log_admin( "Ban Expired: " + key );
				GlobalFuncs.message_admins( "Ban Expired: " + key );
			} else {
				GlobalFuncs.ban_unban_log_save( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " unbanned " + key );
				GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " unbanned " + key );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " unbanned: " + key );
				GlobalFuncs.feedback_inc( "ban_unban", 1 );
				GlobalVars.undefined.user.client.holder.DB_ban_unban( GlobalVars.undefined( key ), 5 );
			}
			A = null;
			foreach (_ in GlobalVars.Banlist.dir ) {
				A = undefined;
				GlobalVars.Banlist.cd = "/base/" + A;
				if ( key == GlobalVars.Banlist.key != null ) {
					GlobalVars.Banlist.cd = "/base";
					GlobalVars.Banlist.dir.Remove( A );
					continue;
				}
			};
			return 1;
		}

		public static int	RemoveBanjob( UNKNOWN [object Object] =null ) {
			UNKNOWN	key = null;
			GlobalVars.Banlistjob.cd = "/base/" + foldername;
			key = GlobalVars.Banlistjob.key._GOOFY_LIST_.read();
			id = GlobalVars.Banlistjob.id._GOOFY_LIST_.read();
			rank = GlobalVars.Banlistjob.rank._GOOFY_LIST_.read();
			GlobalVars.Banlistjob.cd = "/base";
			if ( !GlobalVars.Banlistjob.dir.Remove( foldername ) != null ) {
				return 0;
			}
			if ( !GlobalVars.undefined.user != null ) {
				GlobalFuncs.log_admin( "Banjob Expired: " + key );
				GlobalFuncs.message_admins( "Banjob Expired: " + key );
			} else {
				GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " unjobbanned " + key + " from " + rank );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( GlobalVars.undefined.user ) + " unjobbanned:" + key + " from " + rank );
				GlobalFuncs.ban_unban_log_save( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " unjobbanned " + key + " from " + rank );
				GlobalFuncs.feedback_inc( "ban_job_unban", 1 );
				GlobalFuncs.feedback_add_details( "ban_job_unban", "- " + rank );
			}
			A = null;
			foreach (_ in GlobalVars.Banlistjob.dir ) {
				A = undefined;
				GlobalVars.Banlistjob.cd = "/base/" + A;
				if ( ( key == GlobalVars.Banlistjob.key || id == GlobalVars.Banlistjob.id ) && rank == GlobalVars.Banlistjob.rank != null ) {
					GlobalVars.Banlistjob.cd = "/base";
					GlobalVars.Banlistjob.dir.Remove( A );
					continue;
				}
			};
			return 1;
		}

		public static dynamic	removeNullsFromList( UNKNOWN [object Object] =null ) {
			while (L.Remove( null )) {
				continue;
			};
			return L;
		}

		public static dynamic	repeat_string( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			UNKNOWN _default;
			if ( _string == null != null ) {
				_string = "";
			}
			undefined = "";
			i = null;
			i = 1;
			while (i <= times) {
				undefined += _string;
				i++;
			};
			return _default;
		}

		public static UNKNOWN	replacetext( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( "bin/bygex", "regex_replaceallliteral" )( str, exp, fmt );
		}

		public static UNKNOWN	replacetextEx( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			return GlobalVars.undefined( "bin/bygex", "regEx_replaceallliteral" )( str, exp, fmt );
		}

		public static UNKNOWN	return_file_text( UNKNOWN [object Object] =null ) {
			UNKNOWN	text = null;
			if ( GlobalVars.undefined.exists( filename ) == 0 != null ) {
				throw new Exception( "return_file_text(): File not found", "code/__HELPERS/files.dm", 5 );
				return;
			}
			text = GlobalVars.undefined.read( filename );
			if ( !text != null ) {
				throw new Exception( "return_file_text(): File empty", "code/__HELPERS/files.dm", 10 );
				return;
			}
			return text;
		}

		public static dynamic	reverseRange( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( start == null != null ) {
				start = 1;
			}
			if ( end == null != null ) {
				end = 0;
			}
			if ( L.len != null ) {
				start = start % L.len;
				end = end % ( L.len + 1 );
				if ( start <= 0 != null ) {
					start += L.len;
				}
				if ( end <= 0 != null ) {
					end += L.len + 1;
				}
				end--;
				while (start < end) {
					L.Swap( start++, end-- );
				};
			}
			return L;
		}

		public static dynamic	revoke_maint_all_access(  ) {
			dynamic	A = null;
			A = null;
			foreach (_ in Game ) {
				A = undefined;
				if ( !( A instanceof new ByArea(2826) ) != null ) {
					continue;
				}
				D = null;
				foreach (_ in A ) {
					D = undefined;
					if ( !( D instanceof Ent_Machinery_Door_Airlock ) != null ) {
						continue;
					}
					D.emergency = 0;
					D.$update icon( 0 );
				};
			};
			GlobalFuncs.minor_announce( "Access restrictions in maintenance areas have been restored.", "Attention! Station-wide emergency rescinded:" );
			GlobalVars.emergency_access = 0;
		}

		public static ByTable	rgb2hsl( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	max = null;
			red /= 255;
			green /= 255;
			blue /= 255;
			max = GlobalVars.undefined.max( red, green, blue );
			min = GlobalVars.undefined.min( red, green, blue );
			range = max - min;
			hue = 0;
			saturation = 0;
			lightness = 0;
			lightness = ( max + min ) / 2;
			if ( range != 0 != null ) {
				if ( lightness < 0.5 != null ) {
					saturation = range / ( max + min );
				} else {
					saturation = range / ( 2 - max - min );
				}
				dred = ( max - red ) / ( max * 6 ) + 0.5;
				dgreen = ( max - green ) / ( max * 6 ) + 0.5;
				dblue = ( max - blue ) / ( max * 6 ) + 0.5;
				if ( max == red != null ) {
					hue = dblue - dgreen;
				} else if ( max == green != null ) {
					hue = dred - dblue + 0.3333333432674408;
				} else {
					hue = dgreen - dred + 0.6666666865348816;
				}
				if ( hue < 0 != null ) {
					hue++;
				} else if ( hue > 1 != null ) {
					hue--;
				}
			}
			return new ByTable(new object [] {hue,saturation,lightness});
		}

		public static UNKNOWN	RGBtoHSV( UNKNOWN [object Object] =null ) {
			UNKNOWN	RGB = null;
			if ( !rgb != null ) {
				return "#0000000";
			}
			RGB = GlobalFuncs.ReadRGB( rgb );
			if ( !RGB != null ) {
				return "#0000000";
			}
			r = RGB[1];
			g = RGB[2];
			b = RGB[3];
			hi = GlobalVars.undefined.max( r, g, b );
			lo = GlobalVars.undefined.min( r, g, b );
			val = hi;
			sat = hi ? GlobalVars.undefined.round( ( hi - lo ) * 255 / hi, 1 ) : 0;
			hue = 0;
			if ( sat != null ) {
				if ( hi == r != null ) {
					if ( lo == b != null ) {
						hue = 0;
						dir = 1;
						mid = g;
					} else {
						hue = 1535;
						dir = -1;
						mid = b;
					}
				} else if ( hi == g != null ) {
					if ( lo == r != null ) {
						hue = 512;
						dir = 1;
						mid = b;
					} else {
						hue = 511;
						dir = -1;
						mid = r;
					}
				} else if ( hi == b != null ) {
					if ( lo == g != null ) {
						hue = 1024;
						dir = 1;
						mid = r;
					} else {
						hue = 1023;
						dir = -1;
						mid = g;
					}
				}
				hue += dir * GlobalVars.undefined.round( ( mid - lo ) * 255 / ( hi - lo ), 1 );
			}
			return GlobalFuncs.hsv( hue, sat, val, RGB.len > 3 ? RGB[4] : null );
		}

		public static dynamic	rightandwrong( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	gunslist = null;
			gunslist = new ByTable(new object [] {"taser","egun","laser","revolver","detective","c20r","nuclear","deagle","gyrojet","pulse","suppressed","cannon","doublebarrel","shotgun","combatshotgun","bulldog","mateba","sabr","crossbow","saw","car","boltaction","speargun","arg","uzi"});
			magiclist = new ByTable(new object [] {"fireball","smoke","blind","mindswap","forcewall","knock","horsemask","charge","summonitem","wandnothing","wanddeath","wandresurrection","wandpolymorph","wandteleport","wanddoor","wandfireball","staffchange","staffhealing","armor","scrying","staffdoor","voodoo","special"});
			magicspeciallist = new ByTable(new object [] {"staffchange","staffanimation","wandbelt","contract","staffchaos","necromantic"});
			if ( user != null ) {
				user.write( "<B>You summoned " + ( summon_type ? "magic" : "guns" ) + "!</B>" );
				GlobalFuncs.message_admins( "" + GlobalFuncs.key_name_admin( user, 1 ) + " summoned " + ( summon_type ? "magic" : "guns" ) + "!" );
				GlobalFuncs.log_game( "" + GlobalFuncs.key_name( user ) + " summoned " + ( summon_type ? "magic" : "guns" ) + "!" );
			}
			H = null;
			foreach (_ in GlobalVars.player_list ) {
				H = undefined;
				if ( !( H instanceof Mob_Living_Carbon_Human ) != null ) {
					continue;
				}
				if ( H.stat == 2 || !H.client != null ) {
					continue;
				}
				if ( H.mind != null ) {
					if ( H.mind.special_role == "Wizard" || H.special_role == "apprentice" || H.special_role == "survivalist" != null ) {
						continue;
					}
				}
				if ( Rand.chance( survivor_probability ) && !( H.mind in GlobalVars.ticker.mode.traitors ) != null ) {
					GlobalVars.ticker.mode.traitors += H.mind;
					guns = new Objective_SummonGuns();
					guns.owner = H.mind;
					H.mind.objectives += guns;
					H.mind.special_role = "survivalist";
					survive = new Objective_Survive();
					survive.owner = H.mind;
					H.mind.objectives += survive;
					H.attack_log += "[" + GlobalFuncs.time_stamp() + "] <font color='red'>Was made into a survivalist, and trusts no one!</font>";
					H.write( "<B>You are the survivalist! Your own safety matters above all else, and the only way to ensure your safety is to stockpile weapons! Grab as many guns as possible, by any means necessary. Kill anyone who gets in your way.</B>" );
					obj_count = 1;
					OBJ = null;
					foreach (_ in H.mind.objectives ) {
						OBJ = undefined;
						if ( !( OBJ instanceof Objective ) != null ) {
							continue;
						}
						H.write( "<B>Objective #" + obj_count + "</B>: " + OBJ.explanation_text );
						obj_count++;
					};
				}
				randomizeguns = Rand.pick( gunslist );
				randomizemagic = Rand.pick( magiclist );
				randomizemagicspecial = Rand.pick( magicspeciallist );
				if ( !summon_type != null ) {
					local _ = randomizeguns // Was a switch-case, sorry for the mess.
					if ( _=="taser" ) {
						new Ent_Item_Weapon_Gun_Energy_Gun_Advtaser( GlobalFuncs.get_turf( H ) );
					} else if ( _=="egun" ) {
						new Ent_Item_Weapon_Gun_Energy_Gun( GlobalFuncs.get_turf( H ) );
					} else if ( _=="laser" ) {
						new Ent_Item_Weapon_Gun_Energy_Laser( GlobalFuncs.get_turf( H ) );
					} else if ( _=="revolver" ) {
						new Ent_Item_Weapon_Gun_Projectile_Revolver( GlobalFuncs.get_turf( H ) );
					} else if ( _=="detective" ) {
						new Ent_Item_Weapon_Gun_Projectile_Revolver_Detective( GlobalFuncs.get_turf( H ) );
					} else if ( _=="deagle" ) {
						new Ent_Item_Weapon_Gun_Projectile_Automatic_Pistol_Deagle_Camo( GlobalFuncs.get_turf( H ) );
					} else if ( _=="gyrojet" ) {
						new Ent_Item_Weapon_Gun_Projectile_Automatic_Gyropistol( GlobalFuncs.get_turf( H ) );
					} else if ( _=="pulse" ) {
						new Ent_Item_Weapon_Gun_Energy_Pulse( GlobalFuncs.get_turf( H ) );
					} else if ( _=="suppressed" ) {
						new Ent_Item_Weapon_Gun_Projectile_Automatic_Pistol( GlobalFuncs.get_turf( H ) );
						new Ent_Item_Weapon_Suppressor( GlobalFuncs.get_turf( H ) );
					} else if ( _=="doublebarrel" ) {
						new Ent_Item_Weapon_Gun_Projectile_Revolver_Doublebarrel( GlobalFuncs.get_turf( H ) );
					} else if ( _=="shotgun" ) {
						new Ent_Item_Weapon_Gun_Projectile_Shotgun( GlobalFuncs.get_turf( H ) );
					} else if ( _=="combatshotgun" ) {
						new Ent_Item_Weapon_Gun_Projectile_Shotgun_Automatic_Combat( GlobalFuncs.get_turf( H ) );
					} else if ( _=="arg" ) {
						new Ent_Item_Weapon_Gun_Projectile_Automatic_Ar( GlobalFuncs.get_turf( H ) );
					} else if ( _=="mateba" ) {
						new Ent_Item_Weapon_Gun_Projectile_Revolver_Mateba( GlobalFuncs.get_turf( H ) );
					} else if ( _=="boltaction" ) {
						new Ent_Item_Weapon_Gun_Projectile_Shotgun_Boltaction( GlobalFuncs.get_turf( H ) );
					} else if ( _=="speargun" ) {
						new Ent_Item_Weapon_Gun_Projectile_Automatic_Speargun( GlobalFuncs.get_turf( H ) );
					} else if ( _=="uzi" ) {
						new Ent_Item_Weapon_Gun_Projectile_Automatic_MiniUzi( GlobalFuncs.get_turf( H ) );
					} else if ( _=="cannon" ) {
						gat = new Ent_Item_Weapon_Gun_Energy_Lasercannon( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="crossbow" ) {
						gat = new Ent_Item_Weapon_Gun_Energy_KineticAccelerator_Crossbow_Large( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="nuclear" ) {
						gat = new Ent_Item_Weapon_Gun_Energy_Gun_Nuclear( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="sabr" ) {
						gat = new Ent_Item_Weapon_Gun_Projectile_Automatic_Proto( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="bulldog" ) {
						gat = new Ent_Item_Weapon_Gun_Projectile_Automatic_Shotgun_Bulldog( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="c20r" ) {
						gat = new Ent_Item_Weapon_Gun_Projectile_Automatic_C20r( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="saw" ) {
						gat = new Ent_Item_Weapon_Gun_Projectile_Automatic_L6Saw( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					} else if ( _=="car" ) {
						gat = new Ent_Item_Weapon_Gun_Projectile_Automatic_M90( GlobalFuncs.get_turf( H ) );
						gat.pin = new Ent_Item_Device_FiringPin();
					};
					GlobalFuncs.playsound( GlobalFuncs.get_turf( H ), new ByRsc(56), 50, 1 );
				} else {
					local _ = randomizemagic // Was a switch-case, sorry for the mess.
					if ( _=="fireball" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Fireball( GlobalFuncs.get_turf( H ) );
					} else if ( _=="smoke" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Smoke( GlobalFuncs.get_turf( H ) );
					} else if ( _=="blind" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Blind( GlobalFuncs.get_turf( H ) );
					} else if ( _=="mindswap" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Mindswap( GlobalFuncs.get_turf( H ) );
					} else if ( _=="forcewall" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Forcewall( GlobalFuncs.get_turf( H ) );
					} else if ( _=="knock" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Knock( GlobalFuncs.get_turf( H ) );
					} else if ( _=="horsemask" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Barnyard( GlobalFuncs.get_turf( H ) );
					} else if ( _=="charge" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Charge( GlobalFuncs.get_turf( H ) );
					} else if ( _=="summonitem" ) {
						new Ent_Item_Weapon_Spellbook_Oneuse_Summonitem( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wandnothing" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wanddeath" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand_Death( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wandresurrection" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand_Resurrection( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wandpolymorph" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand_Polymorph( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wandteleport" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand_Teleport( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wanddoor" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand_Door( GlobalFuncs.get_turf( H ) );
					} else if ( _=="wandfireball" ) {
						new Ent_Item_Weapon_Gun_Magic_Wand_Fireball( GlobalFuncs.get_turf( H ) );
					} else if ( _=="staffhealing" ) {
						new Ent_Item_Weapon_Gun_Magic_Staff_Healing( GlobalFuncs.get_turf( H ) );
					} else if ( _=="staffdoor" ) {
						new Ent_Item_Weapon_Gun_Magic_Staff_Door( GlobalFuncs.get_turf( H ) );
					} else if ( _=="armor" ) {
						new Ent_Item_Clothing_Suit_Space_Hardsuit_Wizard( GlobalFuncs.get_turf( H ) );
					} else if ( _=="scrying" ) {
						new Ent_Item_Weapon_Scrying( GlobalFuncs.get_turf( H ) );
						if ( !H.dna.check_mutation( "X Ray Vision" ) != null ) {
							H.$add mutation( "X Ray Vision" );
							H.write( "<span class='notice'>The walls suddenly disappear.</span>" );
						}
					} else if ( _=="voodoo" ) {
						new Ent_Item_Voodoo( GlobalFuncs.get_turf( H ) );
					} else if ( _=="special" ) {
						magiclist -= "special";
						local _ = randomizemagicspecial // Was a switch-case, sorry for the mess.
						if ( _=="staffchange" ) {
							new Ent_Item_Weapon_Gun_Magic_Staff_Change( GlobalFuncs.get_turf( H ) );
						} else if ( _=="staffanimation" ) {
							new Ent_Item_Weapon_Gun_Magic_Staff_Animate( GlobalFuncs.get_turf( H ) );
						} else if ( _=="wandbelt" ) {
							new Ent_Item_Weapon_Storage_Belt_Wands_Full( GlobalFuncs.get_turf( H ) );
						} else if ( _=="contract" ) {
							new Ent_Item_Weapon_AntagSpawner_Contract( GlobalFuncs.get_turf( H ) );
						} else if ( _=="staffchaos" ) {
							new Ent_Item_Weapon_Gun_Magic_Staff_Chaos( GlobalFuncs.get_turf( H ) );
						} else if ( _=="necromantic" ) {
							new Ent_Item_Device_NecromanticStone( GlobalFuncs.get_turf( H ) );
						};
						H.write( "<span class='notice'>You suddenly feel lucky.</span>" );
					};
					GlobalFuncs.playsound( GlobalFuncs.get_turf( H ), new ByRsc(57), 50, 1 );
				}
			};
		}

		public static dynamic	rights2text( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	verbpath = null;
			UNKNOWN _default;
			if ( seperator == null != null ) {
				seperator = "";
			}
			if ( rights & 1 != null ) {
				undefined += "" + seperator + "+BUILDMODE";
			}
			if ( rights & 2 != null ) {
				undefined += "" + seperator + "+ADMIN";
			}
			if ( rights & 4 != null ) {
				undefined += "" + seperator + "+BAN";
			}
			if ( rights & 8 != null ) {
				undefined += "" + seperator + "+FUN";
			}
			if ( rights & 16 != null ) {
				undefined += "" + seperator + "+SERVER";
			}
			if ( rights & 32 != null ) {
				undefined += "" + seperator + "+DEBUG";
			}
			if ( rights & 64 != null ) {
				undefined += "" + seperator + "+POSSESS";
			}
			if ( rights & 128 != null ) {
				undefined += "" + seperator + "+PERMISSIONS";
			}
			if ( rights & 256 != null ) {
				undefined += "" + seperator + "+STEALTH";
			}
			if ( rights & 512 != null ) {
				undefined += "" + seperator + "+REJUVINATE";
			}
			if ( rights & 1024 != null ) {
				undefined += "" + seperator + "+VAREDIT";
			}
			if ( rights & 2048 != null ) {
				undefined += "" + seperator + "+SOUND";
			}
			if ( rights & 4096 != null ) {
				undefined += "" + seperator + "+SPAWN";
			}
			verbpath = null;
			foreach (_ in adds ) {
				verbpath = undefined;
				undefined += "" + seperator + "+" + verbpath;
			};
			verbpath = null;
			foreach (_ in subs ) {
				verbpath = undefined;
				undefined += "" + seperator + "-" + verbpath;
			};
			return undefined;
			return _default;
		}

		public static dynamic	robogibs( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			new Ent_Effect_Gibspawner_Robot( location, viruses );
		}

		public static string	RoundDiagBar( UNKNOWN [object Object] =null ) {
			local _ = value * 100 // Was a switch-case, sorry for the mess.
			if ( 95<=_&&_<=9.999999848243207e+30 ) {
				return "max";
			} else if ( 80<=_&&_<=100 ) {
				return "good";
			} else if ( 60<=_&&_<=80 ) {
				return "high";
			} else if ( 40<=_&&_<=60 ) {
				return "med";
			} else if ( 20<=_&&_<=40 ) {
				return "low";
			} else if ( 1<=_&&_<=20 ) {
				return "crit";
			} else {
				return "dead";
			};
			return "dead";
		}

		public static string	RoundHealth( UNKNOWN [object Object] =null ) {
			local _ = health // Was a switch-case, sorry for the mess.
			if ( 100<=_&&_<=9.999999848243207e+30 ) {
				return "health100";
			} else if ( 70<=_&&_<=100 ) {
				return "health80";
			} else if ( 50<=_&&_<=70 ) {
				return "health60";
			} else if ( 30<=_&&_<=50 ) {
				return "health40";
			} else if ( 18<=_&&_<=30 ) {
				return "health25";
			} else if ( 5<=_&&_<=18 ) {
				return "health10";
			} else if ( 1<=_&&_<=5 ) {
				return "health1";
			} else if ( -99<=_&&_<=0 ) {
				return "health0";
			} else {
				return "health-100";
			};
			return "0";
		}

		public static UNKNOWN	safepick( UNKNOWN [object Object] =null ) {
			if ( L instanceof new List && L.len != null ) {
				return Rand.pick( L );
			}
		}

		public static UNKNOWN	sanitize( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( repl_chars == null != null ) {
				repl_chars = null;
			}
			return GlobalVars.undefined( GlobalFuncs.sanitize_simple( t, repl_chars ) );
		}

		public static UNKNOWN	sanitize_frequency( UNKNOWN [object Object] =null ) {
			f = GlobalVars.undefined.round( f );
			f = GlobalVars.undefined.max( 1441, f );
			f = GlobalVars.undefined.min( 1489, f );
			if ( f % 2 == 0 != null ) {
				f += 1;
			}
			return f;
		}

		public static UNKNOWN	sanitize_gender( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( neuter == null != null ) {
				neuter = 0;
			}
			if ( plural == null != null ) {
				plural = 0;
			}
			if ( __default == null != null ) {
				__default = "male";
			}
			local _ = gender // Was a switch-case, sorry for the mess.
			if ( _=="male" || _=="female" ) {
				return gender;
			} else if ( _=="neuter" ) {
				if ( neuter != null ) {
					return gender;
				} else {
					return __default;
				}
			} else if ( _=="plural" ) {
				if ( plural != null ) {
					return gender;
				} else {
					return __default;
				}
			};
			return __default;
		}

		public static UNKNOWN	sanitize_hexcolor( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	crunch = null;
			UNKNOWN _default;
			if ( desired_format == null != null ) {
				desired_format = 3;
			}
			if ( include_crunch == null != null ) {
				include_crunch = 0;
			}
			crunch = include_crunch ? "#" : "";
			if ( !GlobalVars.undefined( color ) != null ) {
				color = "";
			}
			start = ( GlobalVars.undefined( color, 1 ) == 35 ) + 1;
			len = GlobalVars.undefined( color );
			step_size = ( len + 1 - start != desired_format ) + 1;
			undefined = "";
			i = null;
			i = start;
			while (i <= len) {
				ascii = GlobalVars.undefined( color, i );
				local _ = ascii // Was a switch-case, sorry for the mess.
				if ( 48<=_&&_<=57 ) {
					undefined += GlobalVars.undefined( ascii );
				} else if ( 97<=_&&_<=102 ) {
					undefined += GlobalVars.undefined( ascii );
				} else if ( 65<=_&&_<=70 ) {
					undefined += GlobalVars.undefined( ascii + 32 );
				} else {
					break;
				};
				i += step_size;
			};
			if ( GlobalVars.undefined( undefined ) != desired_format != null ) {
				if ( __default != null ) {
					return __default;
				}
				return crunch + GlobalFuncs.repeat_string( desired_format, "0" );
			}
			return crunch + undefined;
			return _default;
		}

		public static UNKNOWN	sanitize_inlist( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( value in List != null ) {
				return value;
			}
			if ( __default != null ) {
				return __default;
			}
			if ( List && List.len != null ) {
				return Rand.pick( List );
			}
		}

		public static UNKNOWN	sanitize_integer( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( min == null != null ) {
				min = 0;
			}
			if ( max == null != null ) {
				max = 1;
			}
			if ( __default == null != null ) {
				__default = 0;
			}
			if ( GlobalVars.undefined( number ) != null ) {
				number = GlobalVars.undefined.round( number );
				if ( min <= number && number <= max != null ) {
					return number;
				}
			}
			return __default;
		}

		public static UNKNOWN	sanitize_ooccolor( UNKNOWN [object Object] =null ) {
			UNKNOWN	HSL = null;
			HSL = GlobalFuncs.rgb2hsl( GlobalFuncs.hex2num( GlobalVars.undefined( color, 2, 4 ) ), GlobalFuncs.hex2num( GlobalVars.undefined( color, 4, 6 ) ), GlobalFuncs.hex2num( GlobalVars.undefined( color, 6, 8 ) ) );
			HSL[3] = GlobalVars.undefined.min( HSL[3], 0.4000000059604645 );
			RGB = GlobalFuncs.get_dist_euclidian.lcall( HSL );
			return "#" + GlobalFuncs.num2hex( RGB[1], 2 ) + GlobalFuncs.num2hex( RGB[2], 2 ) + GlobalFuncs.num2hex( RGB[3], 2 );
		}

		public static UNKNOWN	sanitize_simple( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	_char = null;
			if ( repl_chars == null != null ) {
				repl_chars = new ByTable().set( "	", "#" ).set( "\n", "#" );
			}
			_char = null;
			foreach (_ in repl_chars ) {
				_char = undefined;
				index = GlobalVars.undefined( t, _char, 1, null );
				while (index) {
					t = GlobalVars.undefined( t, 1, index ) + repl_chars[_char] + GlobalVars.undefined( t, index + 1, null );
					index = GlobalVars.undefined( t, _char, index + 1, null );
				};
			};
			return t;
		}

		public static string	sanitize_text( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( __default == null != null ) {
				__default = "";
			}
			if ( GlobalVars.undefined( text ) != null ) {
				return text;
			}
			return __default;
		}

		public static UNKNOWN	sanitizeSQL( UNKNOWN [object Object] =null ) {
			UNKNOWN	sqltext = null;
			sqltext = GlobalVars.dbcon.Quote( t );
			return GlobalVars.undefined( sqltext, 2, GlobalVars.undefined( sqltext ) );
		}

		public static int	scramble_dna( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			if ( ui == null != null ) {
				ui = GlobalVars.FALSE;
			}
			if ( se == null != null ) {
				se = GlobalVars.FALSE;
			}
			if ( !M.has_dna() != null ) {
				return 0;
			}
			if ( se != null ) {
				i = null;
				i = 1;
				while (i <= 20) {
					if ( Rand.chance( probability ) != null ) {
						M.dna.struc_enzymes = GlobalFuncs.setblock( M.dna.struc_enzymes, i, GlobalFuncs.random_string( 3, GlobalVars.hex_characters ) );
					}
					i++;
				};
				M.domutcheck();
			}
			if ( ui != null ) {
				i = null;
				i = 1;
				while (i <= 7) {
					if ( Rand.chance( probability ) != null ) {
						M.dna.uni_identity = GlobalFuncs.setblock( M.dna.uni_identity, i, GlobalFuncs.random_string( 3, GlobalVars.hex_characters ) );
					}
					i++;
				};
				M.updateappearance.lcall( new ByTable().set( "mutations_overlay_update", 1 ) );
			}
			return 1;
		}

		public static UNKNOWN	screen_loc2turf( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	tX = null;
			tX = GlobalFuncs.text2list( scr_loc, "," );
			tY = GlobalFuncs.text2list( tX[2], ":" );
			tZ = origin.z;
			tY = tY[1];
			tX = GlobalFuncs.text2list( tX[1], ":" );
			tX = tX[1];
			tX = GlobalVars.undefined.max( 1, GlobalVars.undefined.min( Game.maxx, origin.x + ( GlobalVars.undefined( tX ) - ( Game.view + 1 ) ) ) );
			tY = GlobalVars.undefined.max( 1, GlobalVars.undefined.min( Game.maxy, origin.y + ( GlobalVars.undefined( tY ) - ( Game.view + 1 ) ) ) );
			return GlobalVars.undefined( tX, tY, tZ );
		}

		public static UNKNOWN	SDQL_expression( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	result = null;
			if ( start == null != null ) {
				start = 1;
			}
			result = 0;
			i = null;
			i = start;
			while (i <= expression.len) {
				op = "";
				if ( i > start != null ) {
					op = expression[i];
					i++;
				}
				ret = GlobalFuncs.SDQL_value( _object, expression, i );
				val = ret.val;
				i = ret.i;
				if ( op != "" != null ) {
					local _ = op // Was a switch-case, sorry for the mess.
					if ( _=="+" ) {
						result += val;
					} else if ( _=="-" ) {
						result -= val;
					} else if ( _=="*" ) {
						result *= val;
					} else if ( _=="/" ) {
						result /= val;
					} else if ( _=="&" ) {
						result = result & val;
					} else if ( _=="|" ) {
						result = result | val;
					} else if ( _=="^" ) {
						result = result ^ val;
					} else if ( _=="=" || _=="==" ) {
						result = result == val;
					} else if ( _=="!=" || _=="<>" ) {
						result = result != val;
					} else if ( _=="<" ) {
						result = result < val;
					} else if ( _=="<=" ) {
						result = result <= val;
					} else if ( _==">" ) {
						result = result > val;
					} else if ( _==">=" ) {
						result = result >= val;
					} else if ( _=="and" || _=="&&" ) {
						result = result && val;
					} else if ( _=="or" || _=="||" ) {
						result = result || val;
					} else {
						GlobalVars.undefined.user.write( "<span class='danger'>SDQL2: Unknown op " + op + "</span>" );
						result = null;
					};
				} else {
					result = val;
				}
				i++;
			};
			return result;
		}

		public static ByTable	SDQL_from_objs( UNKNOWN [object Object] =null ) {
			ByTable	_out = null;
			if ( "world" in tree != null ) {
				return new ByTable(new object [] {Game});
			}
			_out = new ByTable();
			type = null;
			foreach (_ in tree ) {
				type = undefined;
				_char = GlobalVars.undefined( type, 1, 2 );
				if ( _char == "/" != null ) {
					_out += GlobalFuncs.SDQL_get_all( type, Game );
				} else if ( _char == "'" || _char == "\"" != null ) {
					_out += GlobalVars.undefined( GlobalVars.undefined( type, 2, GlobalVars.undefined( type ) ) );
				}
			};
			return _out;
		}

		public static ByTable	SDQL_get_all( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	_out = null;
			_out = new ByTable();
			if ( type == "*" != null ) {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( !( d instanceof BaseClass ) != null ) {
						continue;
					}
					_out += d;
				};
				return _out;
			}
			type = GlobalVars.undefined( type );
			if ( GlobalVars.undefined( type, Mob ) != null ) {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( d instanceof type != null ) {
						_out += d;
					}
				};
			} else if ( GlobalVars.undefined( type, Tile ) != null ) {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( d instanceof type != null ) {
						_out += d;
					}
				};
			} else if ( GlobalVars.undefined( type, Entity ) != null ) {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( !( d instanceof Entity ) != null ) {
						continue;
					}
					if ( d instanceof type != null ) {
						_out += d;
					}
				};
			} else if ( GlobalVars.undefined( type, new ByArea(3137) ) != null ) {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( d instanceof type != null ) {
						_out += d;
					}
				};
			} else if ( GlobalVars.undefined( type, BaseStatic ) != null ) {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( !( d instanceof BaseStatic ) != null ) {
						continue;
					}
					if ( d instanceof type != null ) {
						_out += d;
					}
				};
			} else {
				d = null;
				foreach (_ in location ) {
					d = undefined;
					if ( !( d instanceof BaseClass ) != null ) {
						continue;
					}
					if ( d instanceof type != null ) {
						_out += d;
					}
				};
			}
			return _out;
		}

		public static ByTable	SDQL_parse( UNKNOWN [object Object] =null ) {
			SDQLParser	parser = null;
			parser = new SDQLParser();
			querys = new ByTable();
			query_tree = new ByTable();
			pos = 1;
			querys_pos = 1;
			do_parse = 0;
			val = null;
			foreach (_ in query_list ) {
				val = undefined;
				if ( val == ";" != null ) {
					do_parse = 1;
				} else if ( pos >= query_list.len != null ) {
					query_tree += val;
					do_parse = 1;
				}
				if ( do_parse != null ) {
					parser.query = query_tree;
					parsed_tree = null;
					parsed_tree = parser.parse();
					if ( parsed_tree.len > 0 != null ) {
						querys.len = querys_pos;
						querys[querys_pos] = parsed_tree;
						querys_pos++;
					} else {
						GlobalVars.undefined.user.write( GlobalVars.undefined( "<span class='danger'>Parsing error on " ).st_nd_rd( querys_pos ).str( " query. Nothing was executed.</span>" ) );
						return new ByTable();
					}
					query_tree = new ByTable();
					do_parse = 0;
				} else {
					query_tree += val;
				}
				pos++;
			};
			GlobalFuncs.qdel( parser );
			return querys;
		}

		public static dynamic	SDQL_testout( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			string	spaces = null;
			if ( indent == null != null ) {
				indent = 0;
			}
			spaces = "";
			s = null;
			s = 0;
			while (s < indent) {
				spaces += "    ";
				s++;
			};
			item = null;
			foreach (_ in query_tree ) {
				item = undefined;
				if ( item instanceof new List != null ) {
					GlobalVars.undefined.user.write( "" + spaces + "(" );
					GlobalFuncs.SDQL_testout( item, indent + 1 );
					GlobalVars.undefined.user.write( "" + spaces + ")" );
				} else {
					GlobalVars.undefined.user.write( "" + spaces + item );
				}
				if ( !GlobalVars.undefined( item ) && query_tree[item] != null ) {
					if ( query_tree[item] instanceof new List != null ) {
						GlobalVars.undefined.user.write( "" + spaces + "    (" );
						GlobalFuncs.SDQL_testout( query_tree[item], indent + 2 );
						GlobalVars.undefined.user.write( "" + spaces + "    )" );
					} else {
						GlobalVars.undefined.user.write( "" + spaces + "    " + query_tree[item] );
					}
				}
			};
		}

		public static ByTable	SDQL_value( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	i = null;
			if ( start == null != null ) {
				start = 1;
			}
			i = start;
			val = null;
			if ( i > expression.len != null ) {
				return new ByTable().set( "i", i ).set( "val", null );
			}
			if ( expression[i] instanceof new List != null ) {
				val = GlobalFuncs.SDQL_expression( _object, expression[i] );
			} else if ( expression[i] == "!" != null ) {
				ret = GlobalFuncs.SDQL_value( _object, expression, i + 1 );
				val = !ret.val;
				i = ret.i;
			} else if ( expression[i] == "~" != null ) {
				ret = GlobalFuncs.SDQL_value( _object, expression, i + 1 );
				val = ~ret.val;
				i = ret.i;
			} else if ( expression[i] == "-" != null ) {
				ret = GlobalFuncs.SDQL_value( _object, expression, i + 1 );
				val = -ret.val;
				i = ret.i;
			} else if ( expression[i] == "null" != null ) {
				val = null;
			} else if ( GlobalVars.undefined( expression[i] ) != null ) {
				val = expression[i];
			} else if ( GlobalVars.undefined( expression[i], 1, 2 ) in new ByTable(new object [] {"'","\""}) != null ) {
				val = GlobalVars.undefined( expression[i], 2, GlobalVars.undefined( expression[i] ) );
			} else {
				val = GlobalFuncs.SDQL_var( _object, expression, i );
				i = expression.len;
			}
			return new ByTable().set( "i", i ).set( "val", val );
		}

		public static UNKNOWN	SDQL_var( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( start == null != null ) {
				start = 1;
			}
			if ( expression[start] in _object.vars != null ) {
				if ( start < expression.len && expression[start + 1] == "." != null ) {
					return GlobalFuncs.SDQL_var( _object.vars[expression[start]], expression[start + 2] );
				} else {
					return _object.vars[expression[start]];
				}
			} else {
				return;
			}
		}

		public static ByTable	SDQL2_tokenize( UNKNOWN [object Object] =null ) {
			ByTable	whitespace = null;
			whitespace = new ByTable(new object [] {" ","\n","	"});
			single = new ByTable(new object [] {"(",")",",","+","-",".",";"});
			multi = new ByTable()
				.set( "!", new ByTable(new object [] {"","="}) )
				.set( ">", new ByTable(new object [] {"","="}) )
				.set( "<", new ByTable(new object [] {"","=",">"}) )
				.set( "=", new ByTable(new object [] {"","="}) )
				
			;
			word = "";
			query_list = new ByTable();
			len = GlobalVars.undefined( query_text );
			i = null;
			i = 1;
			while (i <= len) {
				_char = GlobalVars.undefined( query_text, i, i + 1 );
				if ( _char in whitespace != null ) {
					if ( word != "" != null ) {
						query_list += word;
						word = "";
					}
				} else if ( _char in single != null ) {
					if ( word != "" != null ) {
						query_list += word;
						word = "";
					}
					query_list += _char;
				} else if ( _char in multi != null ) {
					if ( word != "" != null ) {
						query_list += word;
						word = "";
					}
					char2 = GlobalVars.undefined( query_text, i + 1, i + 2 );
					if ( char2 in multi[_char] != null ) {
						query_list += "" + _char + char2;
						i++;
					} else {
						query_list += _char;
					}
				} else if ( _char == "'" != null ) {
					if ( word != "" != null ) {
						GlobalVars.undefined.user.write( GlobalVars.undefined().red().str( "SDQL2: You have an error in your SDQL syntax, unexpected ' in query: \"<font color=gray>" ).item( query_text ).str( "</font>\" following \"<font color=gray>" ).item( word ).str( "</font>\". Please check your syntax, and try again." ) );
						return;
					}
					word = "'";
					i++;
					while (i <= len) {
						_char = GlobalVars.undefined( query_text, i, i + 1 );
						if ( _char == "'" != null ) {
							if ( GlobalVars.undefined( query_text, i + 1, i + 2 ) == "'" != null ) {
								word += "'";
								i++;
							} else {
								break;
							}
						} else {
							word += _char;
						}
						i++;
					};
					if ( i > len != null ) {
						GlobalVars.undefined.user.write( GlobalVars.undefined().red().str( "SDQL2: You have an error in your SDQL syntax, unmatched ' in query: \"<font color=gray>" ).item( query_text ).str( "</font>\". Please check your syntax, and try again." ) );
						return;
					}
					query_list += "" + word + "'";
					word = "";
				} else if ( _char == "\"" != null ) {
					if ( word != "" != null ) {
						GlobalVars.undefined.user.write( GlobalVars.undefined().red().str( "SDQL2: You have an error in your SDQL syntax, unexpected \" in query: \"<font color=gray>" ).item( query_text ).str( "</font>\" following \"<font color=gray>" ).item( word ).str( "</font>\". Please check your syntax, and try again." ) );
						return;
					}
					word = "\"";
					i++;
					while (i <= len) {
						_char = GlobalVars.undefined( query_text, i, i + 1 );
						if ( _char == "\"" != null ) {
							if ( GlobalVars.undefined( query_text, i + 1, i + 2 ) == "'" != null ) {
								word += "\"";
								i++;
							} else {
								break;
							}
						} else {
							word += _char;
						}
						i++;
					};
					if ( i > len != null ) {
						GlobalVars.undefined.user.write( GlobalVars.undefined().red().str( "SDQL2: You have an error in your SDQL syntax, unmatched \" in query: \"<font color=gray>" ).item( query_text ).str( "</font>\". Please check your syntax, and try again." ) );
						return;
					}
					query_list += "" + word + "\"";
					word = "";
				} else {
					word += _char;
				}
				i++;
			};
			if ( word != "" != null ) {
				query_list += word;
			}
			return query_list;
		}

		public static int	seclevel2num( UNKNOWN [object Object] =null ) {
			local _ = GlobalVars.undefined( seclevel ) // Was a switch-case, sorry for the mess.
			if ( _=="green" ) {
				return 0;
			} else if ( _=="blue" ) {
				return 1;
			} else if ( _=="red" ) {
				return 2;
			} else if ( _=="delta" ) {
				return 3;
			};
		}

		public static int	seedify( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	t_amount = null;
			t_amount = 0;
			if ( t_max == -1 != null ) {
				if ( extractor != null ) {
					t_max = Rand.Int( 1, 4 ) * extractor.seed_multiplier;
				} else {
					t_max = Rand.Int( 1, 4 );
				}
			}
			if ( O instanceof Ent_Item_Weapon_ReagentContainers_Food_Snacks_Grown != null ) {
				F = O;
				while (t_amount < t_max) {
					t_prod = F.seed( O.loc, O );
					t_prod.lifespan = F.lifespan;
					t_prod.endurance = F.endurance;
					t_prod.maturation = F.maturation;
					t_prod.production = F.production;
					t_prod.yield = F.yield;
					t_prod.potency = F.potency;
					t_amount++;
				};
				GlobalFuncs.qdel( O );
				return 1;
			} else if ( O instanceof Ent_Item_Weapon_Grown != null ) {
				F = O;
				if ( F.seed != null ) {
					while (t_amount < t_max) {
						t_prod = F.seed( O.loc, O );
						t_prod.lifespan = F.lifespan;
						t_prod.endurance = F.endurance;
						t_prod.maturation = F.maturation;
						t_prod.production = F.production;
						t_prod.yield = F.yield;
						t_prod.potency = F.potency;
						t_amount++;
					};
					GlobalFuncs.qdel( O );
					return 1;
				} else {
					return 0;
				}
			} else {
				return 0;
			}
		}

		public static dynamic	select_active_ai( UNKNOWN [object Object] =null ) {
			UNKNOWN	ais = null;
			UNKNOWN _default;
			ais = GlobalFuncs.active_ais();
			if ( ais.len != null ) {
				if ( user != null ) {
					undefined = GlobalVars.undefined( user, "AI signals detected:", "AI Selection", ais[1], ais, 0 );
				} else {
					undefined = Rand.pick( ais );
				}
			}
			return undefined;
			return _default;
		}

		public static dynamic	select_active_ai_with_fewest_borgs(  ) {
			dynamic	selected = null;
			active = GlobalFuncs.active_ais();
			A = null;
			foreach (_ in active ) {
				A = undefined;
				if ( !( A instanceof Mob_Living_Silicon_Ai ) != null ) {
					continue;
				}
				if ( !selected || selected.connected_robots.len > A.connected_robots.len != null ) {
					selected = A;
				}
			};
			return selected;
		}

		public static dynamic	select_active_free_borg( UNKNOWN [object Object] =null ) {
			UNKNOWN	borgs = null;
			UNKNOWN _default;
			borgs = GlobalFuncs.active_free_borgs();
			if ( borgs.len != null ) {
				if ( user != null ) {
					undefined = GlobalVars.undefined( user, "Unshackled cyborg signals detected:", "Cyborg Selection", borgs[1], borgs, 0 );
				} else {
					undefined = Rand.pick( borgs );
				}
			}
			return undefined;
			return _default;
		}

		public static dynamic	send_byjax( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	argums = null;
			if ( new_content == null != null ) {
				new_content = null;
			}
			if ( callback == null != null ) {
				callback = null;
			}
			if ( callback_args == null != null ) {
				callback_args = null;
			}
			if ( receiver && target_element && control_id != null ) {
				argums = new ByTable(new object [] {target_element,new_content});
				if ( callback != null ) {
					argums += callback;
					if ( callback_args != null ) {
						argums += callback_args;
					}
				}
				argums = GlobalVars.undefined( argums );
				GlobalVars.undefined( receiver, argums, "" + control_id + ":replaceContent" );
			}
			return;
		}

		public static dynamic	send2irc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( GlobalVars.config.useircbot != null ) {
				GlobalVars.undefined( "python nudge.py " + msg + " " + msg2 );
			}
			return;
		}

		public static UNKNOWN	send2irc_adminless_only( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	admin_number_total = null;
			if ( requiredflags == null != null ) {
				requiredflags = 4;
			}
			admin_number_total = 0;
			admin_number_afk = 0;
			admin_number_ignored = 0;
			admin_number_decrease = 0;
			X = null;
			foreach (_ in GlobalVars.admins ) {
				X = undefined;
				if ( !( X instanceof BAD_GOOFY_EXPANSION??? ) != null ) {
					continue;
				}
				admin_number_total++;
				invalid = 0;
				if ( requiredflags != 0 && !GlobalFuncs.check_rights_for( X, requiredflags ) != null ) {
					admin_number_ignored++;
					invalid = 1;
				}
				if ( X.is_afk() != null ) {
					admin_number_afk++;
					invalid = 1;
				}
				if ( X.holder.fakekey != null ) {
					admin_number_ignored++;
					invalid = 1;
				}
				if ( invalid != null ) {
					admin_number_decrease++;
				}
			};
			admin_number_present = admin_number_total - admin_number_decrease;
			if ( admin_number_present <= 0 != null ) {
				if ( !admin_number_afk && !admin_number_ignored != null ) {
					GlobalFuncs.send2irc( source, "" + msg + " - No admins online" );
				} else {
					GlobalFuncs.send2irc( source, "" + msg + " - All admins AFK (" + admin_number_afk + "/" + admin_number_total + ") or skipped (" + admin_number_ignored + "/" + admin_number_total + ")" );
				}
			}
			return admin_number_present;
		}

		public static dynamic	set_security_level( UNKNOWN [object Object] =null ) {
			dynamic	FA = null;
			local _ = level // Was a switch-case, sorry for the mess.
			if ( _=="green" ) {
				level = 0;
			} else if ( _=="blue" ) {
				level = 1;
			} else if ( _=="red" ) {
				level = 2;
			} else if ( _=="delta" ) {
				level = 3;
			};
			if ( level >= 0 && level <= 3 && level != GlobalVars.security_level != null ) {
				local _ = level // Was a switch-case, sorry for the mess.
				if ( _==0 ) {
					GlobalFuncs.minor_announce( GlobalVars.config.alert_desc_green, "Attention! Security level lowered to green:" );
					GlobalVars.security_level = 0;
					FA = null;
					foreach (_ in GlobalVars.machines ) {
						FA = undefined;
						if ( !( FA instanceof Ent_Machinery_Firealarm ) != null ) {
							continue;
						}
						if ( FA.z == 1 != null ) {
							FA.$update icon();
						}
					};
				} else if ( _==1 ) {
					if ( GlobalVars.security_level < 1 != null ) {
						GlobalFuncs.minor_announce( GlobalVars.config.alert_desc_blue_upto, "Attention! Security level elevated to blue:", 1 );
					} else {
						GlobalFuncs.minor_announce( GlobalVars.config.alert_desc_blue_downto, "Attention! Security level lowered to blue:" );
					}
					GlobalVars.security_level = 1;
					FA = null;
					foreach (_ in GlobalVars.machines ) {
						FA = undefined;
						if ( !( FA instanceof Ent_Machinery_Firealarm ) != null ) {
							continue;
						}
						if ( FA.z == 1 != null ) {
							FA.$update icon();
						}
					};
				} else if ( _==2 ) {
					if ( GlobalVars.security_level < 2 != null ) {
						GlobalFuncs.minor_announce( GlobalVars.config.alert_desc_red_upto, "Attention! Code red!", 1 );
					} else {
						GlobalFuncs.minor_announce( GlobalVars.config.alert_desc_red_downto, "Attention! Code red!" );
					}
					GlobalVars.security_level = 2;
					FA = null;
					foreach (_ in GlobalVars.machines ) {
						FA = undefined;
						if ( !( FA instanceof Ent_Machinery_Firealarm ) != null ) {
							continue;
						}
						if ( FA.z == 1 != null ) {
							FA.$update icon();
						}
					};
					pod = null;
					foreach (_ in GlobalVars.machines ) {
						pod = undefined;
						if ( !( pod instanceof Ent_Machinery_Computer_Shuttle_Pod ) != null ) {
							continue;
						}
						pod.admin_controlled = 0;
					};
				} else if ( _==3 ) {
					GlobalFuncs.minor_announce( GlobalVars.config.alert_desc_delta, "Attention! Delta security level reached!", 1 );
					GlobalVars.security_level = 3;
					FA = null;
					foreach (_ in GlobalVars.machines ) {
						FA = undefined;
						if ( !( FA instanceof Ent_Machinery_Firealarm ) != null ) {
							continue;
						}
						if ( FA.z == 1 != null ) {
							FA.$update icon();
						}
					};
					pod = null;
					foreach (_ in GlobalVars.machines ) {
						pod = undefined;
						if ( !( pod instanceof Ent_Machinery_Computer_Shuttle_Pod ) != null ) {
							continue;
						}
						pod.admin_controlled = 0;
					};
				};
			} else {
				return;
			}
		}

		public static UNKNOWN	setblock( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( blocksize == null != null ) {
				blocksize = 3;
			}
			if ( !istring || !blocknumber || !replacement || !blocksize != null ) {
				return 0;
			}
			return GlobalFuncs.getleftblocks( istring, blocknumber, blocksize ) + replacement + GlobalFuncs.getrightblocks( istring, blocknumber, blocksize );
		}

		public static UNKNOWN	setup_database_connection(  ) {
			string	user = null;
			UNKNOWN _default;
			if ( GlobalVars.failed_db_connections >= 5 != null ) {
				return 0;
			}
			if ( !GlobalVars.dbcon != null ) {
				GlobalVars.dbcon = new DBConnection();
			}
			user = GlobalVars.sqlfdbklogin;
			pass = GlobalVars.sqlfdbkpass;
			db = GlobalVars.sqlfdbkdb;
			address = GlobalVars.sqladdress;
			port = GlobalVars.sqlport;
			GlobalVars.dbcon.Connect( "dbi:mysql:" + db + ":" + address + ":" + port, "" + user, "" + pass );
			undefined = GlobalVars.dbcon.$IsConnected();
			if ( undefined != null ) {
				GlobalVars.failed_db_connections = 0;
			} else {
				GlobalVars.failed_db_connections++;
				if ( GlobalVars.config.sql_enabled != null ) {
					Game.log.write( "SQL error: " + GlobalVars.dbcon.ErrorMsg() );
				}
			}
			return undefined;
			return _default;
		}

		public static dynamic	setup_map_transitions(  ) {
			ByTable	SLS = null;
			SLS = new ByTable();
			conf_set_len = GlobalVars.map_transition_config.len;
			k = 1;
			A = null;
			foreach (_ in GlobalVars.map_transition_config ) {
				A = undefined;
				D = new SpaceLevel( GlobalVars.map_transition_config[A] );
				D.name = A;
				D.z_value = k;
				if ( D.linked < 2 != null ) {
					GlobalVars.z_levels_list["" + D.z_value] = D;
				} else {
					SLS.Add( D );
				}
				k++;
			};
			point_grid = null;
			point_grid = new List( conf_set_len * 2 + 1, conf_set_len * 2 + 1 );
			grid = new ByTable();
			P = null;
			i = null;
			i = 1;
			while (i <= conf_set_len * 2 + 1) {
				j = null;
				j = 1;
				while (j <= conf_set_len * 2 + 1) {
					P = new Point( i, j, point_grid );
					point_grid[i][j] = P;
					grid.Add( P );
					j++;
				};
				i++;
			};
			pnt = null;
			foreach (_ in grid ) {
				pnt = undefined;
				if ( !( pnt instanceof Point ) != null ) {
					continue;
				}
				pnt.set_neigbours( point_grid );
			};
			P = point_grid[conf_set_len + 1][conf_set_len + 1];
			possible_points = new ByTable();
			used_points = new ByTable();
			grid.Cut();
			while (SLS.len) {
				D = Rand.pick( SLS );
				SLS.$Remove( D );
				D.xi = P.x;
				D.yi = P.y;
				P.spl = D;
				possible_points = possible_points | P.neigbours;
				used_points = used_points | P;
				possible_points.Remove( used_points );
				D.set_neigbours( used_points );
				P = Rand.pick( possible_points );
				grid["" + D.z_value] = D;
			};
			A = null;
			foreach (_ in GlobalVars.z_levels_list ) {
				A = undefined;
				grid[A] = GlobalVars.z_levels_list[A];
			};
			S = null;
			foreach (_ in Game ) {
				S = undefined;
				if ( !( S instanceof Tile_Space ) != null ) {
					continue;
				}
				if ( S.x <= 7 != null ) {
					D = grid["" + S.z];
					if ( !D != null ) {
						GlobalVars.undefined( "" + S.z + " position has no space level datum" );
					}
					if ( !D.neigbours.len != null ) {
						continue;
					}
					if ( D.neigbours.8 && D.neigbours.8 != D != null ) {
						D = D.neigbours.8;
						S.destination_z = D.z_value;
					} else {
						while (D.neigbours.4 && D.neigbours.4 != D) {
							D = D.neigbours.4;
						};
						S.destination_z = D.z_value;
					}
					S.destination_x = Game.maxx - 7 - 2;
					S.destination_y = S.y;
				}
				if ( S.x >= Game.maxx - 7 - 1 != null ) {
					D = grid["" + S.z];
					if ( !D != null ) {
						GlobalVars.undefined( "" + S.z + " position has no space level datum" );
					}
					if ( !D.neigbours.len != null ) {
						continue;
					}
					if ( D.neigbours.4 && D.neigbours.4 != D != null ) {
						D = D.neigbours.4;
						S.destination_z = D.z_value;
					} else {
						while (D.neigbours.8 && D.neigbours.8 != D) {
							D = D.neigbours.8;
						};
						S.destination_z = D.z_value;
					}
					S.destination_x = 9;
					S.destination_y = S.y;
				}
				if ( S.y <= 7 != null ) {
					D = grid["" + S.z];
					if ( !D != null ) {
						GlobalVars.undefined( "" + S.z + " position has no space level datum" );
					}
					if ( !D.neigbours.len != null ) {
						continue;
					}
					if ( D.neigbours.2 && D.neigbours.2 != D != null ) {
						D = D.neigbours.2;
						S.destination_z = D.z_value;
					} else {
						while (D.neigbours.1 && D.neigbours.1 != D) {
							D = D.neigbours.1;
						};
						S.destination_z = D.z_value;
					}
					S.destination_x = S.x;
					S.destination_y = Game.maxy - 7 - 2;
				}
				if ( S.y >= Game.maxy - 7 - 1 != null ) {
					D = grid["" + S.z];
					if ( !D != null ) {
						GlobalVars.undefined( "" + S.z + " position has no space level datum" );
					}
					if ( !D.neigbours.len != null ) {
						continue;
					}
					if ( D.neigbours.1 && D.neigbours.1 != D != null ) {
						D = D.neigbours.1;
						S.destination_z = D.z_value;
					} else {
						while (D.neigbours.2 && D.neigbours.2 != D) {
							D = D.neigbours.2;
						};
						S.destination_z = D.z_value;
					}
					S.destination_x = S.x;
					S.destination_y = 9;
				}
			};
			A = null;
			foreach (_ in grid ) {
				A = undefined;
				GlobalVars.z_levels_list[A] = grid[A];
			};
		}

		public static dynamic	SetViruses( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	preserve = null;
			if ( data != null ) {
				preserve = new ByTable();
				if ( data instanceof new List && data.viruses != null ) {
					A = null;
					foreach (_ in data.viruses ) {
						A = undefined;
						if ( !( A instanceof Disease ) != null ) {
							continue;
						}
						preserve += A.Copy();
					};
					R.data = data.Copy();
				}
				if ( preserve.len != null ) {
					R.data.viruses = preserve;
				}
			}
		}

		public static dynamic	shake_camera( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	oldeye = null;
			if ( strength == null != null ) {
				strength = 1;
			}
			::thread.schedule( 0, function() {
				if ( !M || !M.client || M.shakecamera != null ) {
					return;
				}
				oldeye = M.client.eye;
				M.shakecamera = 1;
				x = 0;
				while (x < duration) {
					if ( M && M.client != null ) {
						M.client.eye = GlobalVars.undefined( GlobalFuncs.dd_range( 1, M.loc.x + Rand.Int( -strength, strength ), Game.maxx ), GlobalFuncs.dd_range( 1, M.loc.y + Rand.Int( -strength, strength ), Game.maxy ), M.loc.z );
						GlobalVars.undefined.sleep( 1 );
					}
					x++;
				};
				if ( M != null ) {
					M.shakecamera = 0;
					if ( M.client != null ) {
						M.client.eye = oldeye;
					}
				}
				return;
			});
		}

		public static dynamic	show_note( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			string	output = null;
			if ( linkless == null != null ) {
				linkless = 0;
			}
			ruler = "<hr style='background:#000000; border:0; height:3px'>";
			navbar = "<a href='?_src_=holder;nonalpha=1'>[All]</a>|<a href='?_src_=holder;nonalpha=2'>[#]</a>";
			letter = null;
			foreach (_ in GlobalVars.alphabet ) {
				letter = undefined;
				navbar += "|<a href='?_src_=holder;shownote=" + letter + "'>[" + letter + "]</a>";
			};
			navbar += "<br><form method='GET' name='search' action='?'><input type='hidden' name='_src_' value='holder'><input type='text' name='notessearch' value='" + index + "'><input type='submit' value='Search'></form>";
			if ( !linkless != null ) {
				output = navbar;
			}
			if ( target_ckey != null ) {
				target_sql_ckey = GlobalFuncs.sanitizeSQL( target_ckey );
				query_get_notes = GlobalVars.dbcon.NewQuery( "SELECT id, timestamp, notetext, adminckey, last_editor, server FROM " + GlobalFuncs.format_table_name( "notes" ) + " WHERE ckey = '" + target_sql_ckey + "' ORDER BY timestamp" );
				if ( !query_get_notes.Execute() != null ) {
					err = query_get_notes.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR obtaining ckey, notetext, adminckey, last_editor, server from notes table. Error : [" + err + "]\n" );
					return;
				}
				output += "<h2><center>Notes of " + target_ckey + "</center></h2>";
				if ( !linkless != null ) {
					output += "<center><a href='?_src_=holder;addnote=" + target_ckey + "'>[Add Note]</a></center>";
				}
				output += ruler;
				while (query_get_notes.NextRow()) {
					id = query_get_notes.item[1];
					timestamp = query_get_notes.item[2];
					notetext = query_get_notes.item[3];
					adminckey = query_get_notes.item[4];
					last_editor = query_get_notes.item[5];
					server = query_get_notes.item[6];
					output += "<b>" + timestamp + " | " + server + " | " + adminckey + "</b>";
					if ( !linkless != null ) {
						output += " <a href='?_src_=holder;removenote=" + id + "'>[Remove Note]</a> <a href='?_src_=holder;editnote=" + id + "'>[Edit Note]</a>";
						if ( last_editor != null ) {
							output += " <font size='2'>Last edit by " + last_editor + " <a href='?_src_=holder;noteedits=" + id + "'>(Click here to see edit log)</a></font>";
						}
					}
					output += "<br>" + notetext + "<hr style='background:#000000; border:0; height:1px'>";
				};
			} else if ( index != null ) {
				index_ckey = null;
				search = null;
				output += "<center><a href='?_src_=holder;addnoteempty=1'>[Add Note]</a></center>";
				output += ruler;
				if ( !GlobalVars.undefined( index ) != null ) {
					index = GlobalFuncs.sanitizeSQL( index );
				}
				local _ = index // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					search = "^.";
				} else if ( _==2 ) {
					search = "^[^[:alpha:]]";
				} else {
					search = "^" + index;
				};
				query_list_notes = GlobalVars.dbcon.NewQuery( "SELECT DISTINCT ckey FROM " + GlobalFuncs.format_table_name( "notes" ) + " WHERE ckey REGEXP '" + search + "' ORDER BY ckey" );
				if ( !query_list_notes.Execute() != null ) {
					err = query_list_notes.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR obtaining ckey from notes table. Error : [" + err + "]\n" );
					return;
				}
				while (query_list_notes.NextRow()) {
					index_ckey = query_list_notes.item[1];
					output += "<a href='?_src_=holder;shownoteckey=" + index_ckey + "'>" + index_ckey + "</a><br>";
				};
			} else {
				output += "<center><a href='?_src_=holder;addnoteempty=1'>[Add Note]</a></center>";
				output += ruler;
			}
			GlobalVars.undefined( GlobalVars.undefined.user, output, "window=show_notes;size=900x500" );
		}

		public static UNKNOWN	shuffle( UNKNOWN [object Object] =null ) {
			int	i = null;
			if ( !L != null ) {
				return;
			}
			L = L.Copy();
			i = null;
			i = 1;
			while (i < L.len) {
				L.$Swap( i, Rand.Int( i, L.len ) );
				i++;
			};
			return L;
		}

		public static UNKNOWN	sign( UNKNOWN [object Object] =null ) {
			return x != 0 ? x / GlobalVars.undefined.abs( x ) : 0;
		}

		public static UNKNOWN	SimplifyDegrees( UNKNOWN [object Object] =null ) {
			degrees = degrees % 360;
			if ( degrees < 0 != null ) {
				degrees += 360;
			}
			return degrees;
		}

		public static string	slur( UNKNOWN [object Object] =null ) {
			UNKNOWN	phrase = null;
			phrase = GlobalVars.undefined( n );
			leng = GlobalVars.undefined( phrase );
			counter = GlobalVars.undefined( phrase );
			newphrase = "";
			newletter = "";
			while (counter >= 1) {
				newletter = GlobalVars.undefined( phrase, leng - counter + 1, leng - counter + 2 );
				if ( Rand.Int( 1, 3 ) == 3 != null ) {
					if ( GlobalVars.undefined( newletter ) == "o" != null ) {
						newletter = "u";
					}
					if ( GlobalVars.undefined( newletter ) == "s" != null ) {
						newletter = "ch";
					}
					if ( GlobalVars.undefined( newletter ) == "a" != null ) {
						newletter = "ah";
					}
					if ( GlobalVars.undefined( newletter ) == "u" != null ) {
						newletter = "oo";
					}
					if ( GlobalVars.undefined( newletter ) == "c" != null ) {
						newletter = "k";
					}
				}
				if ( Rand.Int( 1, 20 ) == 20 != null ) {
					if ( newletter == " " != null ) {
						newletter = "...huuuhhh...";
					}
					if ( newletter == "." != null ) {
						newletter = " *BURP*.";
					}
				}
				local _ = Rand.Int( 1, 20 ) // Was a switch-case, sorry for the mess.
				if ( _==1 ) {
					newletter += "'";
				} else if ( _==10 ) {
					newletter += "" + newletter;
				} else if ( _==20 ) {
					newletter += "" + newletter + newletter;
				};
				newphrase += "" + newletter;
				counter -= 1;
			};
			return newphrase;
		}

		public static dynamic	smooth_icon( UNKNOWN [object Object] =null ) {
			UNKNOWN	adjacencies = null;
			if ( GlobalFuncs.qdeleted( A ) != null ) {
				return;
			}
			::thread.schedule( 0, function() {
				if ( A && A.smooth != null ) {
					adjacencies = GlobalFuncs.calculate_adjacencies( A );
					A.clear_smooth_overlays();
					A.top_left_corner = GlobalFuncs.make_nw_corner( adjacencies );
					A.top_right_corner = GlobalFuncs.make_ne_corner( adjacencies );
					A.bottom_left_corner = GlobalFuncs.make_sw_corner( adjacencies );
					A.bottom_right_corner = GlobalFuncs.make_se_corner( adjacencies );
					A.overlays += A.top_left_corner;
					A.overlays += A.top_right_corner;
					A.overlays += A.bottom_right_corner;
					A.overlays += A.bottom_left_corner;
				}
				return;
			});
		}

		public static dynamic	smooth_icon_neighbors( UNKNOWN [object Object] =null ) {
			dynamic	T = null;
			T = null;
			foreach (_ in GlobalVars.undefined( 1, A ) ) {
				T = undefined;
				if ( !( T instanceof BaseStatic ) != null ) {
					continue;
				}
				if ( T.smooth != null ) {
					GlobalFuncs.smooth_icon( T );
				}
			};
		}

		public static dynamic	sortInsert( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( cmp == null != null ) {
				cmp = typeof( GlobalFuncs ).GetMethod( "undefined" );
			}
			if ( fromIndex == null != null ) {
				fromIndex = 1;
			}
			if ( toIndex == null != null ) {
				toIndex = 0;
			}
			if ( L && L.len >= 2 != null ) {
				fromIndex = fromIndex % L.len;
				toIndex = toIndex % ( L.len + 1 );
				if ( fromIndex <= 0 != null ) {
					fromIndex += L.len;
				}
				if ( toIndex <= 0 != null ) {
					toIndex += L.len + 1;
				}
				GlobalVars.sortInstance.L = L;
				GlobalVars.sortInstance.cmp = cmp;
				GlobalVars.sortInstance.associative = associative;
				GlobalVars.sortInstance.$binarySort( fromIndex, toIndex, fromIndex );
			}
			return L;
		}

		public static UNKNOWN	sortKey( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( order == null != null ) {
				order = 1;
			}
			return GlobalFuncs.sortTim( L, order >= 0 ? typeof( GlobalFuncs ).GetMethod( "undefined" ) : typeof( GlobalFuncs ).GetMethod( "undefined" ) );
		}

		public static UNKNOWN	sortList( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( cmp == null != null ) {
				cmp = typeof( GlobalFuncs ).GetMethod( "undefined" );
			}
			return GlobalFuncs.sortTim( L.Copy(), cmp );
		}

		public static ByTable	sortmobs(  ) {
			ByTable	moblist = null;
			moblist = new ByTable();
			sortmob = GlobalFuncs.sortNames( GlobalVars.mob_list );
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Silicon_Ai ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Camera ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Silicon_Pai ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Silicon_Robot ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Carbon_Human ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Carbon_Brain ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Carbon_Alien ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Dead_Observer ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_NewPlayer ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_Carbon_Monkey ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_SimpleAnimal_Slime ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			M = null;
			foreach (_ in sortmob ) {
				M = undefined;
				if ( !( M instanceof Mob_Living_SimpleAnimal ) != null ) {
					continue;
				}
				moblist.Add( M );
			};
			return moblist;
		}

		public static UNKNOWN	sortNames( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( order == null != null ) {
				order = 1;
			}
			return GlobalFuncs.sortTim( L, order >= 0 ? typeof( GlobalFuncs ).GetMethod( "undefined" ) : typeof( GlobalFuncs ).GetMethod( "undefined" ) );
		}

		public static UNKNOWN	sortRecord( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( field == null != null ) {
				field = "name";
			}
			if ( order == null != null ) {
				order = 1;
			}
			GlobalVars.cmp_field = field;
			return GlobalFuncs.sortTim( L, order >= 0 ? typeof( GlobalFuncs ).GetMethod( "undefined" ) : typeof( GlobalFuncs ).GetMethod( "undefined" ) );
		}

		public static dynamic	sortTim( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( cmp == null != null ) {
				cmp = typeof( GlobalFuncs ).GetMethod( "undefined" );
			}
			if ( fromIndex == null != null ) {
				fromIndex = 1;
			}
			if ( toIndex == null != null ) {
				toIndex = 0;
			}
			if ( L && L.len >= 2 != null ) {
				fromIndex = fromIndex % L.len;
				toIndex = toIndex % ( L.len + 1 );
				if ( fromIndex <= 0 != null ) {
					fromIndex += L.len;
				}
				if ( toIndex <= 0 != null ) {
					toIndex += L.len + 1;
				}
				GlobalVars.sortInstance.L = L;
				GlobalVars.sortInstance.cmp = cmp;
				GlobalVars.sortInstance.associative = associative;
				GlobalVars.sortInstance.timSort( fromIndex, toIndex );
			}
			return L;
		}

		public static UNKNOWN	spaceDebrisFinishLoc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	endy = null;
			local _ = startSide // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				endy = 7;
				endx = Rand.Int( 7, Game.maxx - 7 );
			} else if ( _==2 ) {
				endy = Rand.Int( 7, Game.maxy - 7 );
				endx = 7;
			} else if ( _==3 ) {
				endy = Game.maxy - 7;
				endx = Rand.Int( 7, Game.maxx - 7 );
			} else if ( _==4 ) {
				endy = Rand.Int( 7, Game.maxy - 7 );
				endx = Game.maxx - 7;
			};
			T = GlobalVars.undefined( endx, endy, Z );
			return T;
		}

		public static UNKNOWN	spaceDebrisStartLoc( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	starty = null;
			local _ = startSide // Was a switch-case, sorry for the mess.
			if ( _==1 ) {
				starty = Game.maxy - 8;
				startx = Rand.Int( 8, Game.maxx - 8 );
			} else if ( _==2 ) {
				starty = Rand.Int( 8, Game.maxy - 8 );
				startx = Game.maxx - 8;
			} else if ( _==3 ) {
				starty = 8;
				startx = Rand.Int( 8, Game.maxx - 8 );
			} else if ( _==4 ) {
				starty = Rand.Int( 8, Game.maxy - 8 );
				startx = 8;
			};
			T = GlobalVars.undefined( startx, starty, Z );
			return T;
		}

		public static dynamic	spawn_meteor( UNKNOWN [object Object] =null ) {
			UNKNOWN	pickedstart = null;
			max_i = 10;
			while (!( pickedstart instanceof Tile_Space )) {
				startSide = Rand.pick( GlobalVars.cardinal );
				pickedstart = GlobalFuncs.spaceDebrisStartLoc( startSide, 1 );
				pickedgoal = GlobalFuncs.spaceDebrisFinishLoc( startSide, 1 );
				max_i--;
				if ( max_i <= 0 != null ) {
					return;
				}
			};
			Me = GlobalFuncs.pickweight( meteortypes );
			M = Me( pickedstart );
			M.dest = pickedgoal;
			M.z_original = 1;
			::thread.schedule( 0, function() {
				GlobalVars.undefined( M, M.dest, 1 );
				return;
			});
			return;
		}

		public static dynamic	spawn_meteors( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	i = null;
			if ( number == null != null ) {
				number = 10;
			}
			i = null;
			i = 0;
			while (i < number) {
				GlobalFuncs.spawn_meteor( meteortypes );
				i++;
			};
		}

		public static ByTable	spawn_room( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	room_turfs = null;
			room_turfs = new ByTable()
				.set( "floors", new ByTable() )
				.set( "walls", new ByTable() )
				
			;
			x = null;
			x = 0;
			while (x < x_size) {
				y = null;
				y = 0;
				while (y < y_size) {
					T = null;
					cur_loc = GlobalVars.undefined( start_loc.x + x, start_loc.y + y, start_loc.z );
					A = new ByArea(2768)();
					if ( name != null ) {
						A.name = name;
					} else {
						A.name = "Artifact Room #" + A.x + "-" + A.y + "-" + A.z;
					}
					if ( x == 0 || x == x_size - 1 || y == 0 || y == y_size - 1 != null ) {
						wall = GlobalFuncs.pickweight( walltypes );
						T = cur_loc;
						T.ChangeTurf( wall );
						room_turfs.walls += T;
					} else {
						T = cur_loc;
						T.ChangeTurf( floor );
						room_turfs.floors += T;
					}
					A.contents += T;
					y++;
				};
				x++;
			};
			return room_turfs;
		}

		public static dynamic	sql_poll_admins(  ) {
			UNKNOWN	admincount = null;
			if ( !GlobalVars.config.sql_enabled != null ) {
				return;
			}
			admincount = GlobalVars.admins.len;
			GlobalFuncs.establish_db_connection();
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalFuncs.log_game( "SQL ERROR during admin polling. Failed to connect." );
			} else {
				sqltime = GlobalVars.undefined( "YYYY-MM-DD hh:mm:ss", Game.realtime );
				query = GlobalVars.dbcon.NewQuery( "INSERT INTO " + GlobalFuncs.format_table_name( "legacy_population" ) + " (admincount, time) VALUES (" + admincount + ", '" + sqltime + "')" );
				if ( !query.Execute() != null ) {
					err = query.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR during admin polling. Error : [" + err + "]\n" );
				}
			}
		}

		public static dynamic	sql_poll_players(  ) {
			int	playercount = null;
			if ( !GlobalVars.config.sql_enabled != null ) {
				return;
			}
			playercount = 0;
			M = null;
			foreach (_ in GlobalVars.player_list ) {
				M = undefined;
				if ( M.client != null ) {
					playercount += 1;
				}
			};
			GlobalFuncs.establish_db_connection();
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalFuncs.log_game( "SQL ERROR during player polling. Failed to connect." );
			} else {
				sqltime = GlobalVars.undefined( "YYYY-MM-DD hh:mm:ss", Game.realtime );
				query = GlobalVars.dbcon.NewQuery( "INSERT INTO " + GlobalFuncs.format_table_name( "legacy_population" ) + " (playercount, time) VALUES (" + playercount + ", '" + sqltime + "')" );
				if ( !query.Execute() != null ) {
					err = query.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR during player polling. Error : [" + err + "]\n" );
				}
			}
		}

		public static dynamic	sql_report_cyborg_death( UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			if ( !GlobalVars.config.sql_enabled != null ) {
				return;
			}
			if ( !H != null ) {
				return;
			}
			if ( !H.key || !H.mind != null ) {
				return;
			}
			T = H.loc;
			placeofdeath = GlobalFuncs.get_area( T.loc );
			podname = placeofdeath.name;
			sqlname = GlobalFuncs.sanitizeSQL( H.real_name );
			sqlkey = GlobalFuncs.sanitizeSQL( H.key );
			sqlpod = GlobalFuncs.sanitizeSQL( podname );
			sqlspecial = GlobalFuncs.sanitizeSQL( H.mind.special_role );
			sqljob = GlobalFuncs.sanitizeSQL( H.mind.assigned_role );
			if ( H.lastattacker != null ) {
				laname = GlobalFuncs.sanitizeSQL( H.lastattacker.real_name );
				lakey = GlobalFuncs.sanitizeSQL( H.lastattacker.key );
			}
			sqltime = GlobalVars.undefined( "YYYY-MM-DD hh:mm:ss", Game.realtime );
			coord = "" + H.x + ", " + H.y + ", " + H.z;
			GlobalFuncs.establish_db_connection();
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalFuncs.log_game( "SQL ERROR during death reporting. Failed to connect." );
			} else {
				query = GlobalVars.dbcon.NewQuery( "INSERT INTO " + GlobalFuncs.format_table_name( "death" ) + " (name, byondkey, job, special, pod, tod, laname, lakey, gender, bruteloss, fireloss, brainloss, oxyloss, coord) VALUES ('" + sqlname + "', '" + sqlkey + "', '" + sqljob + "', '" + sqlspecial + "', '" + sqlpod + "', '" + sqltime + "', '" + laname + "', '" + lakey + "', '" + H.gender + "', " + H.$getBruteLoss() + ", " + H.$getFireLoss() + ", " + H.brainloss + ", " + H.$getOxyLoss() + ", '" + coord + "')" );
				if ( !query.Execute() != null ) {
					err = query.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR during death reporting. Error : [" + err + "]\n" );
				}
			}
		}

		public static dynamic	sql_report_death( UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			if ( !GlobalVars.config.sql_enabled != null ) {
				return;
			}
			if ( !H != null ) {
				return;
			}
			if ( !H.key || !H.mind != null ) {
				return;
			}
			T = H.loc;
			placeofdeath = GlobalFuncs.get_area( T.loc );
			podname = placeofdeath.name;
			sqlname = GlobalFuncs.sanitizeSQL( H.real_name );
			sqlkey = GlobalFuncs.sanitizeSQL( H.key );
			sqlpod = GlobalFuncs.sanitizeSQL( podname );
			sqlspecial = GlobalFuncs.sanitizeSQL( H.mind.special_role );
			sqljob = GlobalFuncs.sanitizeSQL( H.mind.assigned_role );
			if ( H.lastattacker != null ) {
				laname = GlobalFuncs.sanitizeSQL( H.lastattacker.real_name );
				lakey = GlobalFuncs.sanitizeSQL( H.lastattacker.key );
			}
			sqltime = GlobalVars.undefined( "YYYY-MM-DD hh:mm:ss", Game.realtime );
			coord = "" + H.x + ", " + H.y + ", " + H.z;
			GlobalFuncs.establish_db_connection();
			if ( !GlobalVars.dbcon.IsConnected() != null ) {
				GlobalFuncs.log_game( "SQL ERROR during death reporting. Failed to connect." );
			} else {
				query = GlobalVars.dbcon.NewQuery( "INSERT INTO " + GlobalFuncs.format_table_name( "death" ) + " (name, byondkey, job, special, pod, tod, laname, lakey, gender, bruteloss, fireloss, brainloss, oxyloss, coord) VALUES ('" + sqlname + "', '" + sqlkey + "', '" + sqljob + "', '" + sqlspecial + "', '" + sqlpod + "', '" + sqltime + "', '" + laname + "', '" + lakey + "', '" + H.gender + "', " + H.$getBruteLoss() + ", " + H.$getFireLoss() + ", " + H.brainloss + ", " + H.$getOxyLoss() + ", '" + coord + "')" );
				if ( !query.Execute() != null ) {
					err = query.$ErrorMsg();
					GlobalFuncs.log_game( "SQL ERROR during death reporting. Error : [" + err + "]\n" );
				}
			}
		}

		public static UNKNOWN	SQLtime(  ) {
			return GlobalVars.undefined( "YYYY-MM-DD hh:mm:ss", Game.realtime );
		}

		public static UNKNOWN	stars( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	te = null;
			n = GlobalVars.undefined( n );
			if ( pr == null != null ) {
				pr = 25;
			}
			if ( pr <= 0 != null ) {
				return;
			} else if ( pr >= 100 != null ) {
				return n;
			}
			te = n;
			t = "";
			n = GlobalVars.undefined( n );
			p = null;
			p = 1;
			while (p <= n) {
				if ( GlobalVars.undefined( te, p, p + 1 ) == " " || Rand.chance( pr ) != null ) {
					t = "" + t + GlobalVars.undefined( te, p, p + 1 );
				} else {
					t = "" + t + "*";
				}
				p++;
			};
			return GlobalFuncs.sanitize( t );
		}

		public static dynamic	stickyban2list( UNKNOWN [object Object] =null ) {
			if ( !ban != null ) {
				return;
			}
			undefined = GlobalVars.undefined( ban );
			undefined.keys = GlobalFuncs.text2list( undefined.keys, "," );
			undefined.type = GlobalFuncs.text2list( undefined.type, "," );
			undefined.IP = GlobalFuncs.text2list( undefined.IP, "," );
			undefined.computer_id = GlobalFuncs.text2list( undefined.computer_id, "," );
			return _default;
		}

		public static ByTable	string2listofvars( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	var_found = null;
			UNKNOWN _default;
			if ( !t_string || !var_source != null ) {
				return new ByTable();
			}
			undefined = new ByTable();
			var_found = GlobalVars.undefined( t_string, "[", 1, null );
			if ( var_found != null ) {
				t_string = GlobalFuncs.replacetext( t_string, "[", "[ " );
				list_value = GlobalFuncs.text2list( t_string, "[" );
				intermediate_stage = GlobalFuncs.list2text( list_value );
				list_value = GlobalFuncs.text2list( intermediate_stage, " " );
				value = null;
				foreach (_ in list_value ) {
					value = undefined;
					if ( GlobalVars.undefined( value, "]", 1, null ) != null ) {
						value = GlobalFuncs.text2list( value, "]" );
						A = null;
						foreach (_ in value ) {
							A = undefined;
							if ( var_source.vars.Find( A ) != null ) {
								undefined += A;
							}
						};
					}
				};
			}
			return _default;
		}

		public static UNKNOWN	strings( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	fileList = null;
			if ( !GlobalVars.string_cache != null ) {
				GlobalVars.string_cache = new List();
			}
			if ( !( filename in GlobalVars.string_cache ) != null ) {
				if ( GlobalVars.undefined.exists( "strings/" + filename ) != null ) {
					GlobalVars.string_cache[filename] = new ByTable();
					stringsList = new ByTable();
					fileList = GlobalFuncs.file2list( "strings/" + filename );
					s = null;
					foreach (_ in fileList ) {
						s = undefined;
						stringsList = GlobalFuncs.text2list( s, "@=" );
						if ( stringsList.len != 2 != null ) {
							GlobalVars.undefined( "Invalid string list in strings/" + filename );
						}
						if ( GlobalVars.undefined( stringsList[2], "@,", 1, null ) != null ) {
							GlobalVars.string_cache[filename][stringsList[1]] = GlobalFuncs.text2list( stringsList[2], "@," );
						} else {
							GlobalVars.string_cache[filename][stringsList[1]] = stringsList[2];
						}
					};
				} else {
					GlobalVars.undefined( "file not found: strings/" + filename );
				}
			}
			if ( filename in GlobalVars.string_cache && key in GlobalVars.string_cache[filename] != null ) {
				return GlobalVars.string_cache[filename][key];
			} else {
				GlobalVars.undefined( "strings list not found: strings/" + filename + ", index=" + key );
			}
		}

		public static UNKNOWN	strip_html_simple( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			ByTable	strip_chars = null;
			if ( limit == null != null ) {
				limit = 1024;
			}
			strip_chars = new ByTable(new object [] {"<",">"});
			t = GlobalVars.undefined( t, 1, limit );
			_char = null;
			foreach (_ in strip_chars ) {
				_char = undefined;
				index = GlobalVars.undefined( t, _char, 1, null );
				while (index) {
					t = GlobalVars.undefined( t, 1, index ) + GlobalVars.undefined( t, index + 1, null );
					index = GlobalVars.undefined( t, _char, 1, null );
				};
			};
			return t;
		}

		public static UNKNOWN	stripped_input( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	name = null;
			if ( message == null != null ) {
				message = "";
			}
			if ( title == null != null ) {
				title = "";
			}
			if ( __default == null != null ) {
				__default = "";
			}
			if ( max_length == null != null ) {
				max_length = 1024;
			}
			name = GlobalVars.undefined( user, message, title, __default, null, 132 );
			return GlobalFuncs.trim( GlobalVars.undefined( name ), max_length );
		}

		public static UNKNOWN	stripped_multiline_input( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	name = null;
			if ( message == null != null ) {
				message = "";
			}
			if ( title == null != null ) {
				title = "";
			}
			if ( __default == null != null ) {
				__default = "";
			}
			if ( max_length == null != null ) {
				max_length = 1024;
			}
			name = GlobalVars.undefined( user, message, title, __default, null, 2176 );
			return GlobalVars.undefined( GlobalFuncs.trim( name, max_length ) );
		}

		public static UNKNOWN	stutter( UNKNOWN [object Object] =null ) {
			UNKNOWN	te = null;
			te = GlobalVars.undefined( n );
			t = "";
			n = GlobalVars.undefined( n );
			p = null;
			p = 1;
			while (p <= n) {
				n_letter = GlobalVars.undefined( te, p, p + 1 );
				if ( Rand.chance( 80 ) && GlobalVars.undefined( n_letter ) in new ByTable(new object [] {"b","c","d","f","g","h","j","k","l","m","n","p","q","r","s","t","v","w","x","y","z"}) != null ) {
					if ( Rand.chance( 10 ) != null ) {
						n_letter = "" + n_letter + "-" + n_letter + "-" + n_letter + "-" + n_letter;
					} else if ( Rand.chance( 20 ) != null ) {
						n_letter = "" + n_letter + "-" + n_letter + "-" + n_letter;
					} else if ( Rand.chance( 5 ) != null ) {
						n_letter = null;
					} else {
						n_letter = "" + n_letter + "-" + n_letter;
					}
				}
				t = "" + t + n_letter;
				p++;
			};
			return GlobalVars.undefined( GlobalFuncs.sanitize( t ), 1, 1024 );
		}

		public static dynamic	summonevents(  ) {
			if ( !GlobalVars.SSevent.wizardmode != null ) {
				GlobalVars.SSevent.frequency_lower = 600;
				GlobalVars.SSevent.frequency_upper = 3000;
				GlobalVars.SSevent.toggleWizardmode();
				GlobalVars.SSevent.$reschedule();
			} else {
				GlobalVars.SSevent.frequency_upper -= 600;
				if ( GlobalVars.SSevent.frequency_upper < GlobalVars.SSevent.frequency_lower != null ) {
					GlobalVars.SSevent.frequency_upper = GlobalVars.SSevent.frequency_lower;
				}
				GlobalVars.SSevent.reschedule();
				GlobalFuncs.message_admins( "Summon Events intensifies, events will now occur every " + GlobalVars.SSevent.frequency_lower / 600 + " to " + GlobalVars.SSevent.frequency_upper / 600 + " minutes." );
				GlobalFuncs.log_game( "Summon Events was increased!" );
			}
		}

		public static dynamic	Syndicate_announce( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	msg = null;
			msg = GlobalVars.undefined( GlobalFuncs.sanitize( text ), 1, 1024 );
			msg = GlobalVars.undefined( "<span class='adminnotice'><b><font color=crimson>SYNDICATE:</font>" ).item( GlobalFuncs.key_name_admin( Sender ) ).str( " (<A HREF='?_src_=holder;adminmoreinfo=" ).ref( Sender ).str( "'>?</A>) (<A HREF='?_src_=holder;adminplayeropts=" ).ref( Sender ).str( "'>PP</A>) (<A HREF='?_src_=vars;Vars=" ).ref( Sender ).str( "'>VV</A>) (<A HREF='?_src_=holder;subtlemessage=" ).ref( Sender ).str( "'>SM</A>) (<A HREF='?_src_=holder;adminplayerobservefollow=" ).ref( Sender ).str( "'>FLW</A>) (<A HREF='?_src_=holder;traitor=" ).ref( Sender ).str( "'>TP</A>) (<A HREF='?_src_=holder;BlueSpaceArtillery=" ).ref( Sender ).str( "'>BSA</A>) (<A HREF='?_src_=holder;SyndicateReply=" ).ref( Sender ).str( "'>RPLY</A>):</b> " ).item( msg ).str( "</span>" );
			GlobalVars.admins.write( msg );
		}

		public static dynamic	testing( UNKNOWN [object Object] =null ) {
			
		}

		public static int	text2dir_extended( UNKNOWN [object Object] =null ) {
			local _ = GlobalVars.undefined( direction ) // Was a switch-case, sorry for the mess.
			if ( _=="NORTH" || _=="N" ) {
				return 1;
			} else if ( _=="SOUTH" || _=="S" ) {
				return 2;
			} else if ( _=="EAST" || _=="E" ) {
				return 4;
			} else if ( _=="WEST" || _=="W" ) {
				return 8;
			} else if ( _=="NORTHEAST" || _=="NE" ) {
				return 5;
			} else if ( _=="NORTHWEST" || _=="NW" ) {
				return 9;
			} else if ( _=="SOUTHEAST" || _=="SE" ) {
				return 6;
			} else if ( _=="SOUTHWEST" || _=="SW" ) {
				return 10;
			};
			return 0;
		}

		public static ByTable	text2list( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	delim_len = null;
			UNKNOWN _default;
			if ( delimiter == null != null ) {
				delimiter = "\n";
			}
			delim_len = GlobalVars.undefined( delimiter );
			if ( delim_len < 1 != null ) {
				return new ByTable(new object [] {text});
			}
			undefined = new ByTable();
			last_found = 1;
			while (1) { // Was a do-while, sorry for the mess.
				found = GlobalVars.undefined( text, delimiter, last_found, 0 );
				undefined += GlobalVars.undefined( text, last_found, found );
				last_found = found + delim_len;
				if (!( found )) break;
			};
			return _default;
		}

		public static UNKNOWN	time_stamp( UNKNOWN [object Object] =null ) {
			if ( format == null != null ) {
				format = "hh:mm:ss";
			}
			return GlobalVars.undefined( format, Game.timeofday );
		}

		public static int	tkMaxRangeCheck( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	d = null;
			d = GlobalVars.undefined( user, target );
			if ( focus != null ) {
				d = GlobalVars.undefined.max( d, GlobalVars.undefined( user, focus ) );
			}
			if ( d > GlobalVars.tk_maxrange != null ) {
				user.write( "<span class ='warning'>Your mind won't reach that far.</span>" );
				return 0;
			}
			return 1;
		}

		public static dynamic	toggle_ooc( UNKNOWN [object Object] =null ) {
			if ( toggle == null != null ) {
				toggle = null;
			}
			if ( toggle != null != null ) {
				if ( toggle != GlobalVars.ooc_allowed != null ) {
					GlobalVars.ooc_allowed = toggle;
				} else {
					return;
				}
			} else {
				GlobalVars.ooc_allowed = !GlobalVars.ooc_allowed;
			}
			Game.write( "<B>The OOC channel has been globally " + ( GlobalVars.ooc_allowed ? "enabled" : "disabled" ) + ".</B>" );
		}

		public static dynamic	togglebuildmode( UNKNOWN [object Object] =null ) {
			dynamic	H = null;
			if ( M.client != null ) {
				if ( M.client.buildmode != null ) {
					GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has left build mode." );
					M.client.buildmode = 0;
					M.client.show_popup_menus = 1;
					H = null;
					foreach (_ in Game ) {
						H = undefined;
						if ( !( H instanceof Ent_Effect_Bmode_Buildholder ) != null ) {
							continue;
						}
						if ( H.cl == M.client != null ) {
							GlobalFuncs.qdel( H );
						}
					};
				} else {
					GlobalFuncs.message_admins( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has entered build mode." );
					GlobalFuncs.log_admin( "" + GlobalFuncs.key_name( GlobalVars.undefined.user ) + " has entered build mode." );
					M.client.buildmode = 1;
					M.client.show_popup_menus = 0;
					H = new Ent_Effect_Bmode_Buildholder();
					A = new Ent_Effect_Bmode_Builddir( H );
					A.master = H;
					B = new Ent_Effect_Bmode_Buildhelp( H );
					B.master = H;
					C = new Ent_Effect_Bmode_Buildmode( H );
					C.master = H;
					D = new Ent_Effect_Bmode_Buildquit( H );
					D.master = H;
					H.builddir = A;
					H.buildhelp = B;
					H.buildmode = C;
					H.buildquit = D;
					M.client.screen += A;
					M.client.screen += B;
					M.client.screen += C;
					M.client.screen += D;
					H.cl = M.client;
				}
			}
		}

		public static UNKNOWN	trange( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	x1y1 = null;
			if ( Dist == null != null ) {
				Dist = 0;
			}
			if ( Center == null != null ) {
				Center = null;
			}
			if ( Center == null != null ) {
				return;
			}
			x1y1 = GlobalVars.undefined( Center.x - Dist < 1 ? 1 : Center.x - Dist, Center.y - Dist < 1 ? 1 : Center.y - Dist, Center.z );
			x2y2 = GlobalVars.undefined( Center.x + Dist > Game.maxx ? Game.maxx : Center.x + Dist, Center.y + Dist > Game.maxy ? Game.maxy : Center.y + Dist, Center.z );
			return GlobalVars.undefined( x1y1, x2y2 );
		}

		public static int	transform_dir( UNKNOWN [object Object] =null ) {
			local _ = direction // Was a switch-case, sorry for the mess.
			if ( _==1 || _==2 || _==4 || _==8 ) {
				return direction;
			} else if ( _==5 ) {
				return 16;
			} else if ( _==9 ) {
				return 32;
			} else if ( _==6 ) {
				return 64;
			} else if ( _==10 ) {
				return 128;
			};
		}

		public static UNKNOWN	TransformUsingVariable( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	inputToDegrees = null;
			if ( scaling_modifier == null != null ) {
				scaling_modifier = 0;
			}
			inputToDegrees = input / inputmaximum * 180;
			size_factor = ( -GlobalVars.undefined.cos( inputToDegrees ) + 1 ) / 2;
			return size_factor + scaling_modifier;
		}

		public static UNKNOWN	trim( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( max_length != null ) {
				text = GlobalVars.undefined( text, 1, max_length );
			}
			return GlobalFuncs.trim_left( GlobalFuncs.trim_right( text ) );
		}

		public static UNKNOWN	trim_left( UNKNOWN [object Object] =null ) {
			dynamic	i = null;
			i = null;
			foreach (_ in GlobalVars.undefined( 1, GlobalVars.undefined( text ) ) ) {
				i = undefined;
				if ( GlobalVars.undefined( text, i ) > 32 != null ) {
					return GlobalVars.undefined( text, i, null );
				}
			};
			return "";
		}

		public static UNKNOWN	trim_right( UNKNOWN [object Object] =null ) {
			UNKNOWN	i = null;
			i = null;
			i = GlobalVars.undefined( text );
			while (i > 0) {
				if ( GlobalVars.undefined( text, i ) > 32 != null ) {
					return GlobalVars.undefined( text, 1, i + 1 );
				}
				i--;
			};
			return "";
		}

		public static dynamic	try_move_adjacent( UNKNOWN [object Object] =null ) {
			UNKNOWN	T = null;
			T = GlobalFuncs.get_turf( AM );
			direction = null;
			foreach (_ in GlobalVars.cardinal ) {
				direction = undefined;
				if ( AM.Move( GlobalVars.undefined( T, direction ) ) != null ) {
					break;
				}
			};
		}

		public static UNKNOWN	ui_style2icon( UNKNOWN [object Object] =null ) {
			local _ = ui_style // Was a switch-case, sorry for the mess.
			if ( _=="Retro" ) {
				return new ByRsc(12);
			} else if ( _=="Plasmafire" ) {
				return new ByRsc(13);
			} else {
				return new ByRsc(14);
			};
		}

		public static ByTable	ultra_range( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	t_center = null;
			if ( dist == null != null ) {
				dist = 0;
			}
			if ( center == null != null ) {
				center = GlobalVars.undefined.user;
			}
			if ( orange == null != null ) {
				orange = 0;
			}
			if ( !dist != null ) {
				if ( !orange != null ) {
					return new ByTable(new object [] {center});
				} else {
					return new ByTable();
				}
			}
			t_center = GlobalFuncs.get_turf( center );
			if ( !t_center != null ) {
				return new ByTable();
			}
			L = new ByTable();
			c_dist = 1;
			if ( !orange != null ) {
				L += t_center;
				L += t_center.contents;
			}
			while (c_dist <= dist) {
				y = t_center.y + c_dist;
				x = t_center.x - c_dist + 1;
				foreach (_ in GlobalVars.undefined( x, t_center.x + c_dist ) ) {
					x = undefined;
					T = GlobalVars.undefined( x, y, t_center.z );
					if ( T != null ) {
						L += T;
						L += T.contents;
					}
				};
				y = t_center.y + c_dist - 1;
				x = t_center.x + c_dist;
				foreach (_ in GlobalVars.undefined( t_center.y - c_dist, y ) ) {
					y = undefined;
					T = GlobalVars.undefined( x, y, t_center.z );
					if ( T != null ) {
						L += T;
						L += T.contents;
					}
				};
				y = t_center.y - c_dist;
				x = t_center.x + c_dist - 1;
				foreach (_ in GlobalVars.undefined( t_center.x - c_dist, x ) ) {
					x = undefined;
					T = GlobalVars.undefined( x, y, t_center.z );
					if ( T != null ) {
						L += T;
						L += T.contents;
					}
				};
				y = t_center.y - c_dist + 1;
				x = t_center.x - c_dist;
				foreach (_ in GlobalVars.undefined( y, t_center.y + c_dist ) ) {
					y = undefined;
					T = GlobalVars.undefined( x, y, t_center.z );
					if ( T != null ) {
						L += T;
						L += T.contents;
					}
				};
				c_dist++;
			};
			return L;
		}

		public static UNKNOWN	unix2date( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			int	year = null;
			if ( seperator == null != null ) {
				seperator = "-";
			}
			if ( timestamp < 0 != null ) {
				return 0;
			}
			year = 1970;
			dayInSeconds = 86400;
			daysInYear = 365;
			daysInLYear = daysInYear + 1;
			days = GlobalVars.undefined.round( timestamp / dayInSeconds );
			tmpDays = days + 1;
			monthsInDays = new ByTable();
			month = 1;
			while (tmpDays > daysInYear) {
				year++;
				if ( GlobalFuncs.isLeap( year ) != null ) {
					tmpDays -= daysInLYear;
				} else {
					tmpDays -= daysInYear;
				}
			};
			if ( GlobalFuncs.isLeap( year ) != null ) {
				monthsInDays = new ByTable(new object [] {-1,30,59,90,120,151,181,212,243,273,304,334});
			} else {
				monthsInDays = new ByTable(new object [] {0,31,59,90,120,151,181,212,243,273,304,334});
			}
			mDays = 0;
			monthIndex = 0;
			m = null;
			foreach (_ in monthsInDays ) {
				m = undefined;
				monthIndex++;
				if ( tmpDays > m != null ) {
					mDays = m;
					month = monthIndex;
				}
			};
			day = tmpDays - mDays;
			return "" + year + seperator + ( month < 10 ? "0" + month : month ) + seperator + ( day < 10 ? "0" + day : day );
		}

		public static dynamic	updateallghostimages(  ) {
			dynamic	O = null;
			O = null;
			foreach (_ in GlobalVars.player_list ) {
				O = undefined;
				if ( !( O instanceof Mob_Dead_Observer ) != null ) {
					continue;
				}
				O.updateghostimages();
			};
		}

		public static int	UpdateTime(  ) {
			GlobalVars.CMinutes = Game.realtime / 10 / 60;
			return 1;
		}

		public static dynamic	view_or_range( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			if ( distance == null != null ) {
				distance = Game.view;
			}
			if ( center == null != null ) {
				center = GlobalVars.undefined.user;
			}
			local _ = type // Was a switch-case, sorry for the mess.
			if ( _=="view" ) {
				undefined = GlobalVars.undefined( distance, center );
			} else if ( _=="range" ) {
				undefined = GlobalVars.undefined( distance, center );
			};
			return;
			return _default;
		}

		public static UNKNOWN	vol_by_throwforce_and_or_w_class( UNKNOWN [object Object] =null ) {
			if ( !I != null ) {
				return 0;
			}
			if ( I.throwforce && I.w_class != null ) {
				return GlobalFuncs.Clamp( ( I.throwforce + I.w_class ) * 5, 30, 100 );
			} else if ( I.w_class != null ) {
				return GlobalFuncs.Clamp( I.w_class * 8, 20, 100 );
			} else {
				return 0;
			}
		}

		public static UNKNOWN	wabbajack( UNKNOWN [object Object] =null ) {
			dynamic	Robot = null;
			if ( M instanceof Mob_Living != null ) {
				if ( M instanceof Mob_Living && M.stat != 2 != null ) {
					if ( M.notransform != null ) {
						return;
					}
					M.notransform = 1;
					M.canmove = 0;
					M.icon = null;
					M.overlays.Cut();
					M.invisibility = 101;
					if ( M instanceof Mob_Living_Silicon_Robot != null ) {
						Robot = M;
						if ( Robot.mmi != null ) {
							GlobalFuncs.qdel( Robot.mmi );
						}
						Robot.notify_ai( 1 );
					} else {
						W = null;
						foreach (_ in M ) {
							W = undefined;
							if ( !( W instanceof Ent_Item ) != null ) {
								continue;
							}
							if ( W instanceof Ent_Item_Weapon_Implant != null ) {
								GlobalFuncs.qdel( W );
								continue;
							}
							W.layer = GlobalVars.undefined( W.layer );
							W.loc = M.loc;
							W.$dropped( M );
						};
					}
					new_mob = null;
					randomize = Rand.pick(new object [] { "monkey", "robot", "slime", "xeno", "humanoid", "animal" });
					local _ = randomize // Was a switch-case, sorry for the mess.
					if ( _=="monkey" ) {
						new_mob = new Mob_Living_Carbon_Monkey( M.loc );
						new_mob.languages = new_mob.languages | 1;
					} else if ( _=="robot" ) {
						robot = Rand.pick(new object [] { "cyborg", "syndiborg", "drone" });
						local _ = robot // Was a switch-case, sorry for the mess.
						if ( _=="cyborg" ) {
							new_mob = new Mob_Living_Silicon_Robot( M.loc );
						} else if ( _=="syndiborg" ) {
							new_mob = new Mob_Living_Silicon_Robot_Syndicate( M.loc );
						} else if ( _=="drone" ) {
							new_mob = new Mob_Living_SimpleAnimal_Drone( M.loc );
							D = new_mob;
							D.update_drone_hack();
						};
						if ( new_mob instanceof Mob_Living_Silicon != null ) {
							new_mob.gender = M.gender;
							new_mob.invisibility = 0;
							new_mob.job = "Cyborg";
							Robot = new_mob;
							Robot.mmi = new Ent_Item_Device_Mmi( new_mob );
							Robot.mmi.transfer_identity( M );
						} else {
							new_mob.languages = new_mob.languages | 1;
						}
					} else if ( _=="slime" ) {
						new_mob = new Mob_Living_SimpleAnimal_Slime( M.loc );
						if ( Rand.chance( 50 ) != null ) {
							Slime = new_mob;
							Slime.is_adult = 1;
						}
						new_mob.languages = new_mob.languages | 1;
					} else if ( _=="xeno" ) {
						if ( Rand.chance( 50 ) != null ) {
							new_mob = new Mob_Living_Carbon_Alien_Humanoid_Hunter( M.loc );
						} else {
							new_mob = new Mob_Living_Carbon_Alien_Humanoid_Sentinel( M.loc );
						}
						new_mob.languages = new_mob.languages | 1;
					} else if ( _=="animal" ) {
						if ( Rand.chance( 50 ) != null ) {
							beast = Rand.pick(new object [] { "carp", "bear", "mushroom", "statue", "bat", "goat", "killertomato", "spiderbase", "spiderhunter", "blobbernaut", "magicarp", "chaosmagicarp" });
							local _ = beast // Was a switch-case, sorry for the mess.
							if ( _=="carp" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Carp( M.loc );
							} else if ( _=="bear" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Bear( M.loc );
							} else if ( _=="mushroom" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Mushroom( M.loc );
							} else if ( _=="statue" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Statue( M.loc );
							} else if ( _=="bat" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Retaliate_Bat( M.loc );
							} else if ( _=="goat" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Retaliate_Goat( M.loc );
							} else if ( _=="killertomato" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Killertomato( M.loc );
							} else if ( _=="spiderbase" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Poison_GiantSpider( M.loc );
							} else if ( _=="spiderhunter" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Poison_GiantSpider_Hunter( M.loc );
							} else if ( _=="blobbernaut" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Blob_Blobbernaut( M.loc );
							} else if ( _=="magicarp" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Carp_Ranged( M.loc );
							} else if ( _=="chaosmagicarp" ) {
								new_mob = new Mob_Living_SimpleAnimal_Hostile_Carp_Ranged_Chaos( M.loc );
							};
						} else {
							animal = Rand.pick(new object [] { "parrot", "corgi", "crab", "pug", "cat", "mouse", "chicken", "cow", "lizard", "chick", "fox", "butterfly" });
							local _ = animal // Was a switch-case, sorry for the mess.
							if ( _=="parrot" ) {
								new_mob = new Mob_Living_SimpleAnimal_Parrot( M.loc );
							} else if ( _=="corgi" ) {
								new_mob = new Mob_Living_SimpleAnimal_Pet_Dog_Corgi( M.loc );
							} else if ( _=="crab" ) {
								new_mob = new Mob_Living_SimpleAnimal_Crab( M.loc );
							} else if ( _=="pug" ) {
								new_mob = new Mob_Living_SimpleAnimal_Pet_Dog_Pug( M.loc );
							} else if ( _=="cat" ) {
								new_mob = new Mob_Living_SimpleAnimal_Pet_Cat( M.loc );
							} else if ( _=="mouse" ) {
								new_mob = new Mob_Living_SimpleAnimal_Mouse( M.loc );
							} else if ( _=="chicken" ) {
								new_mob = new Mob_Living_SimpleAnimal_Chicken( M.loc );
							} else if ( _=="cow" ) {
								new_mob = new Mob_Living_SimpleAnimal_Cow( M.loc );
							} else if ( _=="lizard" ) {
								new_mob = new Mob_Living_SimpleAnimal_Lizard( M.loc );
							} else if ( _=="fox" ) {
								new_mob = new Mob_Living_SimpleAnimal_Pet_Fox( M.loc );
							} else if ( _=="butterfly" ) {
								new_mob = new Mob_Living_SimpleAnimal_Butterfly( M.loc );
							} else {
								new_mob = new Mob_Living_SimpleAnimal_Chick( M.loc );
							};
						}
						new_mob.languages = new_mob.languages | 1;
					} else if ( _=="humanoid" ) {
						new_mob = new Mob_Living_Carbon_Human( M.loc );
						A = new Preferences();
						A.copy_to.lcall( new ByTable().set( "icon_updates", 0 ).set( 1, new_mob ) );
						H = new_mob;
						if ( Rand.chance( 50 ) != null ) {
							all_species = new ByTable();
							speciestype = null;
							foreach (_ in GlobalVars.undefined( Species ) - Species ) {
								speciestype = undefined;
								S = speciestype();
								if ( !S.dangerous_existence != null ) {
									all_species += speciestype;
								}
							};
							H.set_species.lcall( new ByTable().set( "icon_update", 0 ).set( 1, Rand.pick( all_species ) ) );
							H.real_name = H.dna.species.random_name( H.gender, 1 );
						}
						H.update_body();
						H.$update hair();
						H.$update mutcolor();
						H.dna.update_dna_identity();
					} else {
						return;
					};
					new_mob.attack_log = M.attack_log;
					M.attack_log += "[" + GlobalFuncs.time_stamp() + "] <font color='orange'>" + M.real_name + " (" + M.ckey + ") became " + new_mob.real_name + ".</font>";
					new_mob.a_intent = "harm";
					if ( M.mind != null ) {
						M.mind.transfer_to( new_mob );
					} else {
						new_mob.key = M.key;
					}
					new_mob.write( "<B>Your form morphs into that of a " + randomize + ".</B>" );
					GlobalFuncs.qdel( M );
					return new_mob;
				}
			}
		}

		public static dynamic	warning( UNKNOWN [object Object] =null ) {
			Game.log.write( "## WARNING: " + msg );
		}

		public static UNKNOWN	wear_female_version( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			dynamic	index = null;
			index = t_color;
			female_clothing_icon = GlobalVars.female_clothing_icons[index];
			if ( !female_clothing_icon != null ) {
				GlobalFuncs.generate_female_clothing( index, t_color, icon, type );
			}
			standing = GlobalVars.undefined.lcall( new ByTable().set( "layer", -layer ).set( "icon", GlobalVars.female_clothing_icons["" + t_color] ) );
			return standing;
		}

		public static UNKNOWN	worldtime2text(  ) {
			return GlobalFuncs.gameTimestamp( "hh:mm" );
		}

		public static UNKNOWN	Wrap( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			UNKNOWN	d = null;
			d = max - min;
			t = GlobalVars.undefined.round( ( val - min ) / d );
			return val - t * d;
		}

		public static dynamic	xgibs( UNKNOWN [object Object] =null, UNKNOWN [object Object] =null ) {
			new Ent_Effect_Gibspawner_Xeno( location, viruses );
		}

	}
}