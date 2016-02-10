// FILE AUTOGENERATED BY SOMNIUM13.

using System;
using Somnium.Engine.ByImpl;

namespace Somnium.Game {
	class Controller_Process_Pipenet : Controller_Process {

		protected override void __FieldInit() {
			base.__FieldInit();

			this.schedule_interval = 29;
		}

		public Controller_Process_Pipenet ( dynamic scheduler = null ) : base( (object)(scheduler) ) {
			
		}

		// Function from file: pipenet.dm
		public override bool doWork(  ) {
			Obj_Machinery_Atmospherics atmosmachinery = null;
			PipeNetwork pipeNetwork = null;
			dynamic e = null;

			
			foreach (dynamic _a in Lang13.Enumerate( GlobalVars.atmos_machines, typeof(Obj_Machinery_Atmospherics) )) {
				atmosmachinery = _a;
				

				if ( atmosmachinery is Obj_Machinery_Atmospherics ) {
					
					if ( !( atmosmachinery.disposed == true ) && !atmosmachinery.timestopped ) {
						
						if ( Lang13.Bool( atmosmachinery.process() ) ) {
							this.scheck();
						}
					}
					continue;
				}
				GlobalVars.atmos_machines.Remove( atmosmachinery );
			}

			foreach (dynamic _b in Lang13.Enumerate( GlobalVars.pipe_networks, typeof(PipeNetwork) )) {
				pipeNetwork = _b;
				

				if ( pipeNetwork is PipeNetwork ) {
					
					if ( !( pipeNetwork.disposed == true ) ) {
						
						try {
							pipeNetwork.process();
						} catch (Exception __) {
							e = __;
							Game13.Error( e );
							continue;
						}
						this.scheck();
						continue;
					}
				}
				GlobalVars.pipe_networks.Remove( pipeNetwork );
			}
			return false;
		}

		// Function from file: pipenet.dm
		public override void setup(  ) {
			this.name = "pipenet";
			return;
		}

	}

}