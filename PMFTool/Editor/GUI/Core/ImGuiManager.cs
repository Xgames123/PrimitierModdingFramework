using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

namespace PMFTool.Editor.GUI.Core
{
	public class ImGuiManager : IDisposable
	{

		
		private GraphicsDevice _graphicsDevice;
		private CommandList _commandList;
		private ImGuiRenderer _imguiRenderer;

		public Action OnImguiRender;
		public Sdl2Window Window;

		public bool IsDisposed { get; private set; } = false;

		public ImGuiManager(Action onImguiRender, string mainwindowTitle)
		{
			OnImguiRender = onImguiRender;
			VeldridStartup.CreateWindowAndGraphicsDevice(
			new WindowCreateInfo(50, 50, 960, 540, WindowState.Normal, mainwindowTitle),
			out Window,
			out _graphicsDevice);

			_commandList = _graphicsDevice.ResourceFactory.CreateCommandList();

			_imguiRenderer = new ImGuiRenderer(
			   _graphicsDevice,
			   _graphicsDevice.MainSwapchain.Framebuffer.OutputDescription,
			   Window.Width,
			   Window.Height);

			Window.Resized += OnWindowResize;
		}

		private void OnWindowResize()
		{
			_graphicsDevice.ResizeMainWindow((uint)Window.Width, (uint)Window.Height);

		}



		public void Update()
		{
			if (!Window.Exists)
			{
				return;
			}
			var snapshot = Window.PumpEvents();
			_imguiRenderer.Update(1f / 60f, snapshot);

			OnImguiRender?.Invoke();


			_commandList.Begin();
			_commandList.SetFramebuffer(_graphicsDevice.MainSwapchain.Framebuffer);
			_commandList.ClearColorTarget(0, new RgbaFloat(0, 0, 0.2f, 1f));
			_imguiRenderer.Render(_graphicsDevice, _commandList);
			_commandList.End();
			_graphicsDevice.SubmitCommands(_commandList);
			_graphicsDevice.SwapBuffers(_graphicsDevice.MainSwapchain);
		}

		public void Dispose()
		{
			Dispose(true);

		}

		protected virtual void Dispose(bool disposing)
		{
			if (IsDisposed)
			{
				return;
			}
			_graphicsDevice.Dispose();
			_commandList.Dispose();
			Window.Close();
			_imguiRenderer.Dispose();

			IsDisposed = true;
		}

		~ImGuiManager()
		{
			Dispose(false);
		}



	}
}
